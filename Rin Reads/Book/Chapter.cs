using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rin_Reads.Book
{
    public class Chapter
    {

        public Chapter()
        {
            
        }

        // Note getting the data from a json, not all of data needs to be extracted.
        // Some values may be stripped out or replaced by universal functions or classes.

        public string
            ID,
            Title,
            TranslatedLanguage,
            Hash;

        public int
            Volume,
            chapter;

        public DateTime
            CreatedAt,
            UpdatedAt,
            PublishAt;

        public string[]
            PageNames, //gets from data array
            SaverPageNames; //data saver array

        //Or just direct to manga because eh...
        public Relationships
            Manga,
            Uploader;

    }
}

/*
 
{
  "result": "ok",
  "data": {
    "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
    "type": "chapter",
    "attributes": {
      "title": "string",
      "volume": null,
      "chapter": null,
      "translatedLanguage": "jp",
      "data": [
        "x1-b765e86d5ecbc932cf3f517a8604f6ac6d8a7f379b0277a117dc7c09c53d041e.png",
        "x2-fc7c198880083b053bf4e8aebfc0eec1adbe52878a6c5ff08d25544a1d5502ef.png",
        "x3-90f15bc8b91deb0dc88473b532e42a99f93ee9e2c8073795c81b01fff428af80.png"
      ],
      "dataSaver": [
        "x1-ab2b7c8f30c843aa3a53c29bc8c0e204fba4ab3e75985d761921eb6a52ff6159.jpg",
        "x2-3e057d937e01696adce2ac2865f62f6f6a15f03cef43d929b88e99a4b8482e03.jpg",
        "x3-128742088f99806b022bbc8006554456f2a20d0d176d7f3264a65ff9a549d0dd.jpg"
      ],
      "uploader": "4df808f4-cdf8-4d1c-80e6-4af8e6ce09b8",
      "version": 1,
      "groups": [
        "497f6eca-6276-4993-bfeb-53cbbbba6f08"
      ],
      "manga": "e7116dd3-e4ad-4d10-a3ef-6a64d730c341"
    }
  },
  "relationships": [
    {
      "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
      "type": "string"
    }
  ]
}

*/
