using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Addcommunity
    {
        public int Addid { get; set; }
        public int? Userid { get; set; }
        public string Communityname { get; set; }
        public string Descriptions { get; set; }
        public string PictureUrl { get; set; }
        public string City { get; set; }

        public virtual Users User { get; set; }
    }
}
