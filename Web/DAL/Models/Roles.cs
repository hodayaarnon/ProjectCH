using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Authorizations = new HashSet<Authorizations>();
            Joinings = new HashSet<Joinings>();
        }

        public int Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Authorizations> Authorizations { get; set; }
        public virtual ICollection<Joinings> Joinings { get; set; }
    }
}
