using NyaaDB.Api.DBIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyaaDB.Api.AnimeDB;

namespace NyaaDB.Impl.DBIntegration
{
    public class DummyDBManager : DBManager
    {
        public List<NyaaTorrent> SearchAnime(string aTitle, SearchSpecification aSearchSpec)
        {
            return new List<NyaaTorrent>()
            {
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                },
                new NyaaTorrent()
                {
                    Category = 1,
                    Description = "",
                    FileSize = 2312312312,
                    Id = 1,
                    SubCategory = 2,
                    TorrentHash = "239021831290381203182381203",
                    TorrentName = "TestName",
                    UploadDate = DateTime.Now
                }
            };
        }
    };
}
