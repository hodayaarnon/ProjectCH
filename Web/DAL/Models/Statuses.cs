using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Statuses
    {
        public Statuses()
        {
            Transportstates = new HashSet<Transportstates>();
        }

        public int Statusid { get; set; }
        public string Statusname { get; set; }
        public string Descriptions { get; set; }

        public virtual ICollection<Transportstates> Transportstates { get; set; }
    }
}
