using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.Api.AnimeDB
{
    public enum CategoryType
    {
        ALL = 0,
        SOFTWARE = 1,
        AUDIO = 2,
        ANIME = 3,
        LITERATURE = 4,
        LIVE_ACTION = 5,
        PICTURES = 6
    }

    public class Category : CatType
    {
        private CategoryType _catType = 0;

        public CategoryType CatType
        {
            get { return _catType; }
            set { _catType = value; }
        }
    }
}
