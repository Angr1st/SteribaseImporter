using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace SteribaseImporter.DB
{
    class DBTable
    {
        public string Name { get; }
        public List<DBField> DBFields { get; }
        public (List<DBField> primaryKeyFields, DBFieldKeyType pkType) PrimaryKey { get { return DBFields.Count(fields => fields.DBFieldKeyType == DBFieldKeyType.PrimaryKey) == 1 ? (DBFields.FindAll(x => x.DBFieldKeyType == DBFieldKeyType.PrimaryKey), DBFieldKeyType.PrimaryKey) : DBFields.Count(fields => fields.DBFieldKeyType.HasFlag(DBFieldKeyType.ClusteredPrimaryKey)) > 1 ? (DBFields.FindAll(x => x.DBFieldKeyType.HasFlag(DBFieldKeyType.ClusteredPrimaryKey)), DBFieldKeyType.ClusteredPrimaryKey) : default; } }
        public List<DBRow> Rows { get; private set; }

        public DBTable(string name, List<DBField> fields)
        {
            Name = name;
            DBFields = fields;
            Rows = new List<DBRow>();
        }

        public override string ToString() => $"Create table {Name} ({String.Join(",", DBFields)}{KeyStatements()})";

        public bool AddRow(DBRow row)
        {
            Rows.Add(row);
            return true;
        }

        public IEnumerable<MySqlCommand> CreateCommands() => Rows.Select(row => (DBFields.Select(fields => (fields.Name.ToLower(), fields.DBFieldKeyType)), row.DBFieldEntries.Where(entry => entry.DBFieldType != DBFieldType.unkown).Select(fieldEntry => fieldEntry.PrintForInsert()))).Select(touple => CreateCommand(touple));

        private MySqlCommand CreateCommand((IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) touple)
        {
            if (touple.fields.Count(field => field.fieldType.HasFlag(DBFieldKeyType.PrimaryKey)) != 0 && touple.fields.Where(field => field.fieldType.HasFlag(DBFieldKeyType.PrimaryKey)).Select(field => touple.entrys.Count(entry => entry.name == field.fieldName) == 1).Aggregate((newBool, oldBool) => newBool && oldBool))
            {
                var newCommand = new MySqlCommand(FormatCommand(touple));
                AddParameters(newCommand, touple.entrys);
                return newCommand;
            }
            else if (touple.fields.Count(field => field.fieldType.HasFlag(DBFieldKeyType.ClusteredPrimaryKey)) != 0 && touple.fields.Where(field => field.fieldType.HasFlag(DBFieldKeyType.PrimaryKey)).Select(field => touple.entrys.Count(entry => entry.name == field.fieldName) == 1).Aggregate((newBool, oldBool) => newBool && oldBool))
            {

            }
            else
            {
                throw new Exception("The Primary Key Field has no value!");
            }
        }

        private void AddParameters(MySqlCommand command, IEnumerable<(string name, string value)> entrys)
        {
            entrys.Select(entry => command.Parameters.AddWithValue($"@{entry.name}", entry.value));
        }

        private string FormatCommand((IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) touple)
        {
            return $"INSERT Into {Name} ({touple.entrys.Select(entry => entry.name)} Values ({touple.entrys.Select(entry => $"@{entry.name}")}));";
        }

        private string KeyStatements()
        {
            var primaryKey = PrimaryKeyStatement();
            var foreignKey = ForeignKeyStatement();
            return foreignKey.Length != 0 ? $"{primaryKey} ,{foreignKey}" : primaryKey;
        }

        private string PrimaryKeyStatement()
        {
            return PrimaryKey != default(ValueTuple<List<DBField>, DBFieldKeyType>) ? $", Primary key({String.Join(",", PrimaryKey.primaryKeyFields.Select(fields => fields.Name))})" : string.Empty;
        }
        private string ForeignKeyStatement()
        {
            var foreignKeyDefinitions = DBFields.Where(field => field.DBFieldKeyType.HasFlag(DBFieldKeyType.ForeignKey) && field.ReferencesPrimaryKey).Select(field => $"FOREIGN KEY ({field.Name}) REFERENCES {field.ReferencedPrimaryKey.Table.Name}({field.ReferencedPrimaryKey.Field.Name})");
            return String.Join(",", foreignKeyDefinitions);
        }
    }
}
