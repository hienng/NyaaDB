using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.Impl.Settings
{
    public class DBSettings
    {
        private string _dbFilePath = @"E:\\nyaadb.sqlite3";
        private SQLiteConnectionStringBuilder _connectionStringBuilder = new SQLiteConnectionStringBuilder();

        public string DBDataSource
        {
            private get { return _dbFilePath; }
            set { _dbFilePath = value; }
        }

        public string ConnectionString
        {
            get
            {
                _connectionStringBuilder.DataSource = _dbFilePath;
                _connectionStringBuilder.FailIfMissing = true;
                _connectionStringBuilder.ReadOnly = true;

                return _connectionStringBuilder.ConnectionString;
            }
        }
    }
}
