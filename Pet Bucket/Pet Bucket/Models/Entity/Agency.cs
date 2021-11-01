using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Bucket.Models.Entity
{
    public class Agency
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Dob { get; set; }

        public string Gender { get; set; }
        public string Address { get; set; }
    }
}

