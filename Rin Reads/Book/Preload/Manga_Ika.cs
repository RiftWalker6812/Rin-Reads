using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rin_Reads.Book.Preload
{

    public class Manga_Ika
    {
        public string result { get; set; }
        public Data data { get; set; }
        public Relationship[] relationships { get; set; }


        public class Data
        {
            public string id { get; set; }
            public string type { get; set; }
            public Attributes attributes { get; set; }
        }

        public class Attributes
        {
            public Title title { get; set; }
            public Alttitle[] altTitles { get; set; }
            public Description description { get; set; }
            public Links links { get; set; }
            public string originalLanguage { get; set; }
            public string lastVolume { get; set; }
            public string lastChapter { get; set; }
            public string publicationDemographic { get; set; }
            public string status { get; set; }
            public object year { get; set; }
            public string contentRating { get; set; }
            public Tag[] tags { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public int version { get; set; }
        }

        public class Title
        {
            public string en { get; set; }
        }

        public class Description
        {
            public string en { get; set; }
        }

        public class Links
        {
            public string al { get; set; }
            public string ap { get; set; }
            public string kt { get; set; }
            public string mu { get; set; }
            public string mal { get; set; }
        }

        public class Alttitle
        {
            public string en { get; set; }
        }

        public class Tag
        {
            public string id { get; set; }
            public string type { get; set; }
            public Attributes1 attributes { get; set; }
        }

        public class Attributes1
        {
            public Name name { get; set; }
            public object[] description { get; set; }
            public string group { get; set; }
            public int version { get; set; }
        }

        public class Name
        {
            public string en { get; set; }
        }

        public class Relationship
        {
            public string id { get; set; }
            public string type { get; set; }
            public Attributes2 attributes { get; set; }
        }

        public class Attributes2
        {
            public string name { get; set; }
            public object imageUrl { get; set; }
            public object[] biography { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public int version { get; set; }
            public string description { get; set; }
            public object volume { get; set; }
            public string fileName { get; set; }
        }


    }

    

}
