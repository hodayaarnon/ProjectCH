using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Authorizations
    {
        public int Communityid { get; set; }
        public int Roleid { get; set; }

        public virtual Communities Community { get; set; }
        public virtual Roles Role { get; set; }
    }
}
