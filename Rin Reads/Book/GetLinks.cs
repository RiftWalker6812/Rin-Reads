using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rin_Reads.Book
{
    public static class GetLinks
    {
        public static string
            BaseLink = @"https://api.mangadex.org/",
            ChapterLink = BaseLink + "chapter/",
            MangaLink = BaseLink + "manga/",
            AuthoerLink = BaseLink + "author/",
            UploadsLink = @"uploads.mangadex.org/",
            CoverLink = UploadsLink + "cover/";
        public static string GetCoverLink(string mangaID, string coverID) //unique data id
            => $"{CoverLink}{mangaID}/{coverID}.jpg";
        public static string GetCoverLing(string mangaID)
            => throw new NotImplementedException();

        public static string GetAggregate(string mangaID)
            => $"{MangaLink}{mangaID}/aggregate";
    }
}
