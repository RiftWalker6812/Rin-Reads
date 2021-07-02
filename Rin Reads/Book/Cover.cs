using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rin_Reads.Book
{
    
    public class Cover
    {
        public Result[] results { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int total { get; set; }
    }

    

    

}



/*
   {
  "result": "string",
  "data": {
    "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
    "type": "cover_art",
    "attributes": {
      "volume": "string",
      "fileName": "string",
      "description": "string",
      "version": 1,
      "createdAt": "string",
      "updatedAt": "string"
    }
  },
  "relationships": [
    {
      "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
      "type": "string",
      "attributes": {}
    }
  ]
}
*/
