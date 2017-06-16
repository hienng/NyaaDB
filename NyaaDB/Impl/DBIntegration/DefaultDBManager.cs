using NyaaDB.Api.DBIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyaaDB.Api.AnimeDB;
using NyaaDB.Impl.Settings;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Data;

namespace NyaaDB.Impl.DBIntegration
{
    public class DefaultDBManager : DBManager
    {
        private const string searchQuery = @"SELECT * FROM torrents WHERE torrent_name like '%' || @animeTitle || '%'";

        private DefaultDBSettings _dbSettings;
        private SQLiteConnection _sqliteConnection;

        public DefaultDBManager(DefaultDBSettings aDBSettings)
        {
            _dbSettings = aDBSettings;
            _sqliteConnection = new SQLiteConnection(_dbSettings.ConnectionString);

        }

        public List<NyaaTorrent> SearchAnime(string aTitle)
        {
            var nyaaTorrentList = new List<NyaaTorrent>();

            var resultTable = GetTableData(aTitle);

            foreach (DataRow dataRow in resultTable.Rows)
            {
                try
                {
                    var nyaaTorrent = new NyaaTorrent()
                    {
                        Id = Convert.ToInt32(dataRow["torrent_id"]),
                        TorrentName = Convert.ToString(dataRow["torrent_name"]),
                        TorrentHash = Convert.ToString(dataRow["torrent_hash"]),
                        Category = Convert.ToInt32(dataRow["category"]),
                        SubCategory = Convert.ToInt32(dataRow["sub_category"]),
                        UploadDate = Convert.ToDateTime(dataRow["date"]),
                        FileSize = Convert.ToInt64(dataRow["filesize"]),
                        Description = Convert.ToString(dataRow["description"])
                    };

                    nyaaTorrentList.Add(nyaaTorrent);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return nyaaTorrentList;
        }

        private DataTable GetTableData(string aTitle)
        {
            using (var dbConnection = _sqliteConnection)
            {
                dbConnection.Open();

                using (var selectQuery = dbConnection.CreateCommand())
                {
                    selectQuery.CommandText = searchQuery;
                    selectQuery.Parameters.Add(new SQLiteParameter("@animeTitle", aTitle));

                    using (var r = selectQuery.ExecuteReader())
                    {
                        var res = new DataTable();
                        res.Load(r);
                        return res;
                    }

                }
            }
        }
    }
}
