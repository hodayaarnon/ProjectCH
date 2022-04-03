using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Transports
    {
        public Transports()
        {
            Takingsuggestions = new HashSet<Takingsuggestions>();
            Transportstates = new HashSet<Transportstates>();
        }

        public int Transportid { get; set; }
        public int? Userid { get; set; }
        public int? Communityid { get; set; }
        public DateTime? Beginlinetoexec { get; set; }
        public DateTime? Deadlinetoexec { get; set; }
        public double? Packageweight { get; set; }
        public string Packagesize { get; set; }
        public string Contentsdescription { get; set; }
        public string Instructions { get; set; }
        public bool? Confirmedbymanager { get; set; }
        public string ManagerInstruction { get; set; }
        public bool? Foundvolunteer { get; set; }
        public int? Volunteerid { get; set; }
        public DateTime? Estimatedarrivaltime { get; set; }
        public int? Sourceid { get; set; }
        public int? Destinationid { get; set; }
        public bool? Isactive { get; set; }
        public bool? Arrive { get; set; }

        public virtual Communities Community { get; set; }
        public virtual Places Destination { get; set; }
        public virtual Places Source { get; set; }
        public virtual Users User { get; set; }
        public virtual Users Volunteer { get; set; }
        public virtual ICollection<Takingsuggestions> Takingsuggestions { get; set; }
        public virtual ICollection<Transportstates> Transportstates { get; set; }
    }
}
