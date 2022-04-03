using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Joinings
    {
        public int Joiningid { get; set; }
        public int? Userid { get; set; }
        public int? Communityid { get; set; }
        public int? Roleid { get; set; }
        public DateTime? Joinnigdate { get; set; }
        public bool? Isavalid { get; set; }

        public virtual Communities Community { get; set; }
        public virtual Roles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
