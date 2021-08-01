using System.Collections.Generic;

namespace SteribaseImporter.DB
{
    class DBRow
    {
        public List<DBFieldEntry> DBFieldEntries { get; private set; }

        public DBRow(List<DBFieldEntry> dBFieldEntries)
        {
            DBFieldEntries = dBFieldEntries;
        }
    }
}
