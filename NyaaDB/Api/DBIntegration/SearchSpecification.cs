using NyaaDB.Api.AnimeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.Api.DBIntegration
{
    public enum SortOrder { ASC = 0, DESC = 1 }
    public class SearchSpecification
    {
        public CatType SearchCat { get; set; }

        public string SearchBy { get; set; }
        public SortOrder SearchSortOrder { get; set; }
    }
}
