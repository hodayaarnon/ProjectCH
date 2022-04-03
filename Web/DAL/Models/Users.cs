using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Users
    {
        public Users()
        {
            Addcommunity = new HashSet<Addcommunity>();
            Askstojoin = new HashSet<Askstojoin>();
            Communities = new HashSet<Communities>();
            Joinings = new HashSet<Joinings>();
            Takingsuggestions = new HashSet<Takingsuggestions>();
            TransportsUser = new HashSet<Transports>();
            TransportsVolunteer = new HashSet<Transports>();
        }

        public int Userid { get; set; }
        public string Userfirstname { get; set; }
        public string Userlastname { get; set; }
        public string Useridentity { get; set; }
        public string Postalcode { get; set; }
        public string Email { get; set; }
        public string Userpassword { get; set; }
        public double? Adresslat { get; set; }
        public double? Adresslng { get; set; }
        public string Adress { get; set; }
        public string Housenumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int? Placeid { get; set; }

        public virtual Places Place { get; set; }
        public virtual ICollection<Addcommunity> Addcommunity { get; set; }
        public virtual ICollection<Askstojoin> Askstojoin { get; set; }
        public virtual ICollection<Communities> Communities { get; set; }
        public virtual ICollection<Joinings> Joinings { get; set; }
        public virtual ICollection<Takingsuggestions> Takingsuggestions { get; set; }
        public virtual ICollection<Transports> TransportsUser { get; set; }
        public virtual ICollection<Transports> TransportsVolunteer { get; set; }
    }
}
