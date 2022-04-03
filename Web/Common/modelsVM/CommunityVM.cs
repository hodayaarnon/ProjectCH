using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
   public class CommunitiesVM
    {
        public int commuintyId { get; set; }
        public string communityName { get; set; }
        public bool? Requiredpremit { get; set; }
        public string Descriptions { get; set; }
        public string City { get; set; }
        public int? Primemanager { get; set; }
    }
}
