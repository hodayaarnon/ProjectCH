using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Takingsuggestions
    {
        public int Askid { get; set; }
        public int? Volunteerid { get; set; }
        public int? Transportid { get; set; }
        public DateTime? Estimatedarrivaltime { get; set; }
        public bool? Confirmed { get; set; }
        public bool? Relevant { get; set; }

        public virtual Transports Transport { get; set; }
        public virtual Users Volunteer { get; set; }
    }
}
