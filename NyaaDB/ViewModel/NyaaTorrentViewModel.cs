using NyaaDB.Api.AnimeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.ViewModel
{
    public class NyaaTorrentViewModel
    {
        private readonly NyaaTorrent _nyaaTorrent;

        public NyaaTorrentViewModel(NyaaTorrent aNyaaTorrent)
        {
            _nyaaTorrent = aNyaaTorrent;
        }

        public NyaaTorrent NyaaTorrent
        {
            get { return _nyaaTorrent; }
        }

        public string TorrentName
        {
            get { return _nyaaTorrent.TorrentName; }
        }

        public string FileSize
        {
            get { return _nyaaTorrent.FileSize; }
        }

        public string SubCategory
        {
            get { return _nyaaTorrent.SubCategory.ToString(); }
        }
    }
}
