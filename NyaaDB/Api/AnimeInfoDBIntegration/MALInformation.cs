using NyaaDB.Api.AnimeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.Api.AnimeInfoDBIntegration
{
    public interface MALInformation
    {
        MALDescription RetrieveAnimeInformation(string aTitle);
    }
}
