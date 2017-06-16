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
        private const string searchCatQuery = @"SELECT * FROM torrents WHERE torrent_name like '%' || @animeTitle || '%' AND category = @cat";
        private const string searchSubCatQuery = @"SELECT * FROM torrents WHERE torrent_name like '%' || @animeTitle || '%' AND sub_category = @subCat";

        private DefaultDBSettings _dbSettings;
        private SQLiteConnection _sqliteConnection;

        public DefaultDBManager(DefaultDBSettings aDBSettings)
        {
            _dbSettings = aDBSettings;
            _sqliteConnection = new SQLiteConnection(_dbSettings.ConnectionString);
        }

        public List<NyaaTorrent> SearchAnime(string aTitle, SearchSpecification aSearchSpec)
        {
            var resultList = new List<NyaaTorrent>();

            var resultData = GetTableData(aTitle, aSearchSpec.SearchCat);

            if (aSearchSpec.SearchSortOrder == SortOrder.ASC)
            {
                resultData.Select().OrderBy(x => x[aSearchSpec.SearchBy]);
            }
            else
            {
                resultData.Select().OrderByDescending(x => x[aSearchSpec.SearchBy]);
            }

            foreach (DataRow dataRow in resultData.Rows)
            {
                try
                {
                    var nyaaTorrent = new NyaaTorrent()
                    {
                        Id = Convert.ToInt32(dataRow["torrent_id"]),
                        TorrentName = Convert.ToString(dataRow["torrent_name"]),
                        TorrentHash = Convert.IsDBNull(dataRow["torrent_hash"]) ? string.Empty : Convert.ToString(dataRow["torrent_hash"]),
                        Category = Convert.IsDBNull(dataRow["category"]) ? 0 : Convert.ToInt32(dataRow["category"]),
                        SubCategory = Convert.IsDBNull(dataRow["sub_category"]) ? 0 : Convert.ToInt32(dataRow["sub_category"]),
                        UploadDate = Convert.IsDBNull(dataRow["date"]) ? new DateTime() : Convert.ToDateTime(dataRow["date"]),
                        FileSize = Convert.IsDBNull(dataRow["filesize"]) ? string.Empty : Convert.ToString(dataRow["filesize"]),
                        Description = Convert.IsDBNull(dataRow["description"]) ? string.Empty : Convert.ToString(dataRow["description"])
                    };

                    resultList.Add(nyaaTorrent);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            resultData.Dispose();
            return resultList;
        }

        private SQLiteCommand CommandBuilder(string aTitle, CatType aCategory)
        {
            var selectCommand = new SQLiteCommand();
            if (aCategory.GetType() == typeof(Category))
            {
                selectCommand.CommandText = searchCatQuery;
                selectCommand.Parameters.AddWithValue("@cat", (int)((Category)aCategory).CatType);
            }
            else if (aCategory.GetType() == typeof(SubCategory))
            {
                selectCommand.CommandText = searchSubCatQuery;
                selectCommand.Parameters.AddWithValue("@subcat", (int)((SubCategory)aCategory).SubCatType);
            }
            else
            {
                selectCommand.CommandText = searchQuery;
            }

            selectCommand.Parameters.AddWithValue("@animeTitle", aTitle);

            return selectCommand;
        }

        private DataTable GetTableData(string aTitle, CatType aCategory)
        {
            var selectCommand = CommandBuilder(aTitle, aCategory);

            using (var dbConnection = _sqliteConnection)
            {
                dbConnection.Open();

                selectCommand.Connection = dbConnection;

                using (var r = selectCommand.ExecuteReader())
                {
                    var res = new DataTable();
                    res.Load(r);

                    return res;
                }
            }
        }
    }
}
