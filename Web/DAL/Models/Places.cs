using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Places
    {
        public Places()
        {
            TransportsDestination = new HashSet<Transports>();
            TransportsSource = new HashSet<Transports>();
            Users = new HashSet<Users>();
        }

        public int Placeid { get; set; }
        public string Placedescription { get; set; }
        public int? Userid { get; set; }
        public string Contactphone { get; set; }
        public double? Adresslat { get; set; }
        public double? Adresslng { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string Housenumber { get; set; }

        public virtual ICollection<Transports> TransportsDestination { get; set; }
        public virtual ICollection<Transports> TransportsSource { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
