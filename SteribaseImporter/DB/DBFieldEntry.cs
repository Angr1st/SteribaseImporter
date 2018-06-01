using System;
using System.Collections.Generic;
using System.Text;

namespace SteribaseImporter.DB
{
    class DBFieldEntry
    {
        public DateTimeOffset DateTimeOffset { get; private set; }
        public int Int { get; private set; }
        public Double Double { get; private set; }
        public string String { get; private set; }
        public int Length { get; private set; }
        public DBFieldType DBFieldType { get; }
        public string Name { get; }

        public DBFieldEntry(string name, DBFieldType fieldType = DBFieldType.unkown)
        {
            Name = name;
            DBFieldType = fieldType;
        }

        public DBFieldEntry SetDateTimeOffset(DateTimeOffset dateTimeOffset)
        {
            if (DBFieldType.HasFlag(DBFieldType.DateTime))
            {
                DateTimeOffset = dateTimeOffset;
            }
            return this;
        }

        public DBFieldEntry SetInt(int value)
        {
            if (DBFieldType.HasFlag(DBFieldType.@int))
            {
                Int = value;
            }
            return this;
        }

        public DBFieldEntry SetDouble(double value)
        {
            if (DBFieldType.HasFlag(DBFieldType.@double))
            {
                Double = value;
            }
            return this;
        }

        public DBFieldEntry SetString(string value, int length = 200)
        {
            if (DBFieldType.HasFlag(DBFieldType.varchar) && value.Length <= length)
            {
                String = value;
                Length = length;
            }
            return this;
        }

        public (string name, string value) PrintForInsert()
        {
            return (Name, TransformForStringRepresentation());

            string TransformForStringRepresentation()
            {
                switch (DBFieldType)
                {
                    case DBFieldType.varchar:
                        return $"'{String}'";

                    case DBFieldType.@int:
                        return Int.ToString();

                    case DBFieldType.@double:
                        return Double.ToString();

                    case DBFieldType.DateTime:
                        return DateTimeOffset.ToString("u");

                    case DBFieldType.unkown:
                    default:
                        throw new Exception("The DBFieldType is unkown this should not be!");
                }
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
