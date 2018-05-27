using System;
using System.Collections.Generic;
using System.Text;

namespace SteribaseImporter.DB
{
    class DBFieldEntry
    {
        public DateTimeOffset DateTimeOffset { get; private set; }
        public int Int { get; }
        public Double Double { get; }
        public string String { get; }
        public DBFieldType DBFieldType { get; }

        public DBFieldEntry(DBFieldType fieldType = DBFieldType.unkown)
        {
            DBFieldType = fieldType;
        }
    }
}
