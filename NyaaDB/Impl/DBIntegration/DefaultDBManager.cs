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

namespace NyaaDB.Impl.DBIntegration
{
    public class DefaultDBManager : DBManager
    {
        private const string searchQuery = @"SELECT * FROM torrents WHERE torrent_name like '%' || @animeTitle || '%'";

        private DBSettings _dbSettings;
        private SQLiteConnection _sqliteConnection;

        public DefaultDBManager(DBSettings aDBSettings)
        {
            _dbSettings = aDBSettings;
            _sqliteConnection = new SQLiteConnection(_dbSettings.ConnectionString);

        }

        public List<NyaaTorrent> SearchAnime(string aTitle)
        {
            var nyaaTorrentList = new List<NyaaTorrent>();
            using (var dbConnection = _sqliteConnection)
            {
                dbConnection.Open();

                using (var selectQuery = dbConnection.CreateCommand())
                {
                    selectQuery.CommandText = searchQuery;
                    selectQuery.Parameters.Add(new SQLiteParameter("@animeTitle", aTitle));

                    var reader = selectQuery.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            var nyaaTorrent = new NyaaTorrent()
                            {
                                Id = Convert.ToInt32(reader["torrent_id"]),
                                TorrentName = Convert.ToString(reader["torrent_name"]),
                                TorrentHash = Convert.ToString(reader["torrent_hash"]),
                                Category = Convert.ToInt32(reader["category"]),
                                SubCategory = Convert.ToInt32(reader["sub_category"]),
                                UploadDate = Convert.ToDateTime(reader["date"]),
                                FileSize = Convert.ToInt64(reader["filesize"]),
                                Description = Convert.ToString(reader["description"])
                            };

                            nyaaTorrentList.Add(nyaaTorrent);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }

            return nyaaTorrentList;
        }

    }
}
