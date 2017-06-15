using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.Api.DBIntegration
{
    public class NyaaTorrent
    {
        public int Id { get; set; }
        public string TorrentName { get; set; }
        public string TorrentHash { get; set; }
        public int Category { get; set; }
        public int SubCategory { get; set; }
        public DateTime UploadDate { get; set; }
        public long FileSize { get; set; }
        public string Description { get; set; }
    }
}
