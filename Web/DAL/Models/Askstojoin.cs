using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Askstojoin
    {
        public int Askid { get; set; }
        public int? Userid { get; set; }
        public int? Communityid { get; set; }
        public bool? Joinasamanager { get; set; }

        public virtual Communities Community { get; set; }
        public virtual Users User { get; set; }
    }
}
