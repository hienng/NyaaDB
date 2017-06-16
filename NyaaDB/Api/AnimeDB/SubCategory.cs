using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.Api.AnimeDB
{
    public enum SubCategoryType
    {
        SOFTWARE_APPLICATION = 1,
        SOFTWARE_GAMES = 2,
        AUDIO_LOSSLESS = 3,
        AUDIO_LOSSY = 4,
        ANIME_ENG = 5,
        ANIME_RAW = 6,
        LITERATURE_ENG = 7,
        LITERATURE_RAW = 8,
        LIVE_ENG = 9,
        LIVE_IDOL = 10,
        LIVE_RAW = 11,
        ANIME_AMV = 12,
        ANIME_NONENG = 13,
        LITERATURE_NONENG = 14,
        PICTURES_GRAPHICS = 15,
        PICTURES_PHOTOS = 16,
        LIVE_NONENG = 18
    }

    public class SubCategory : CatType
    {
        public SubCategoryType SubCatType { get; set; }
    }
}
