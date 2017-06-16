using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyaaDB.Api.AnimeDB;

namespace NyaaDB.Api.DBIntegration
{
    public interface DBManager
    {
        List<NyaaTorrent> SearchAnime(string aTitle, SearchSpecification aSearchSpec);
    }
}
