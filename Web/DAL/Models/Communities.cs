using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Communities
    {
        public Communities()
        {
            Askstojoin = new HashSet<Askstojoin>();
            Authorizations = new HashSet<Authorizations>();
            Joinings = new HashSet<Joinings>();
            Transports = new HashSet<Transports>();
        }

        public int Communityid { get; set; }
        public string Communityname { get; set; }
        public bool? Requiredpremit { get; set; }
        public string Descriptions { get; set; }
        public string City { get; set; }
        public int? Primemanager { get; set; }

        public virtual Users PrimemanagerNavigation { get; set; }
        public virtual ICollection<Askstojoin> Askstojoin { get; set; }
        public virtual ICollection<Authorizations> Authorizations { get; set; }
        public virtual ICollection<Joinings> Joinings { get; set; }
        public virtual ICollection<Transports> Transports { get; set; }
    }
}
