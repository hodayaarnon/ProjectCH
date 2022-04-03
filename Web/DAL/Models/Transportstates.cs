using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Transportstates
    {
        public int Stateid { get; set; }
        public int? Transportid { get; set; }
        public int? Transportstatus { get; set; }
        public DateTime? Statusstrartdate { get; set; }
        public DateTime? Statusenddate { get; set; }

        public virtual Transports Transport { get; set; }
        public virtual Statuses TransportstatusNavigation { get; set; }
    }
}
