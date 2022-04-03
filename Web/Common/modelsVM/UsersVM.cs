using System;
using System.Collections.Generic;
using System.Text;

namespace Common.modelsVM
{
   public class UsersVM
    {
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
    }
}
