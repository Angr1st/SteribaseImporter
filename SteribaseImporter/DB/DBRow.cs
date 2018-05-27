using System;
using System.Collections.Generic;
using System.Text;

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
