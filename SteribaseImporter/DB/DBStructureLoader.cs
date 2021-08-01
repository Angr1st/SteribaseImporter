using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SteribaseImporter.DB
{
    static class DBStructureLoader
    {
        public static List<DBTable> LoadDBStructure()
        {
            return File.ReadAllLines(ConfigHandler.GetConfigValue(ConfigValues.dbstructure)).Select(Line => CreateDBTable(Line.Split(';'))).ToList();

            DBTable CreateDBTable(string[] splitLine)
            {
                if (splitLine.Length <= 3)
                {
                    throw new ArgumentException("The line does not contain enough arguments");
                }

                var dbTableName = splitLine.First();

                return new DBTable(dbTableName, splitLine.Where(Line => !string.IsNullOrWhiteSpace(Line)).Skip(1).Select(subLine => CreateDBField(subLine.Split(','))).ToList());
            }

            DBField CreateDBField(string[] subSplitLine)
            {
                if (subSplitLine.Length <= 3)
                {
                    throw new ArgumentException("The subline does not contain enough arguments");
                }

                if (subSplitLine.Length == 4)
                {
                    return new DBField(subSplitLine.First(), ParseDBFieldType(subSplitLine.Last()), ParseDBFieldKeyType(subSplitLine.Skip(1).First()));
                }
                else if (subSplitLine.Length == 5)
                {
                    return new DBField(subSplitLine.First(), ParseDBFieldType(subSplitLine.SkipLast(1).Last(),int.Parse(subSplitLine.Last())), ParseDBFieldKeyType(subSplitLine.Skip(1).First()));
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The subLine does contain to many parts!");
                }

                (DBFieldType DBFieldType, int length) ParseDBFieldType(string partOfLine, int length = 0)
                {
                    if (partOfLine == DBFieldType.varchar.ToString())
                    {
                        return (DBFieldType.varchar, length);
                    }
                    else if (partOfLine == DBFieldType.@int.ToString())
                    {
                        return (DBFieldType.@int, length);
                    }
                    else if (partOfLine == DBFieldType.DateTime.ToString())
                    {
                        return (DBFieldType.DateTime, length);
                    }
                    else if (partOfLine == DBFieldType.@double.ToString())
                    {
                        return (DBFieldType.@double, length);
                    }
                    else
                    {
                        throw new ArgumentException($"The value: {partOfLine} and length: {length} do not match any of the supported file types.");
                    }
                }

                DBFieldKeyType ParseDBFieldKeyType(string partOfLine)
                {
                    if (partOfLine == DBFieldKeyType.Value.ToString())
                    {
                        return DBFieldKeyType.Value;
                    }
                    else if (partOfLine == DBFieldKeyType.PrimaryKey.ToString())
                    {
                        return DBFieldKeyType.PrimaryKey;
                    }
                    else if ((partOfLine == DBFieldKeyType.ClusteredPrimaryKey.ToString()))
                    {
                        return DBFieldKeyType.ClusteredPrimaryKey;
                    }
                    else
                    {
                        throw new ArgumentNullException("Could not parse the DBFieldKeyType because the supplied arguement was null, empty or all whitespace!");
                    }
                }
            }
        }
    }
}
