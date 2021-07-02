using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rin_Reads.Book
{
    public class Relationships
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Result
    {
        public string result { get; set; }
        public Data data { get; set; }
        public Relationships[] relationships { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Attributes
    {
        public string description { get; set; }
        public object volume { get; set; }
        public string fileName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int version { get; set; }
    }

}
