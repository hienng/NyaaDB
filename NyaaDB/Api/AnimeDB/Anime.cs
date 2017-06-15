using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.Api.AnimeDB
{
    public class Anime
    {
        public string Title { get; set; }
        public int Season { get; set; }
        public MagnetLink Link { get; set; }
        public MALDescription Description { get; set; }
    }
}
