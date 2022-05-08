using System;
using System.Collections.Generic;
using System.Text;

namespace Common.modelsVM
{
   public class JoiningsVM
    {
        public int Joiningid { get; set; }
        public int? Userid { get; set; }
        public int? Communityid { get; set; }
        public int? Roleid { get; set; }
        public DateTime? Joinnigdate { get; set; }
        public bool? Isavalid { get; set; }
    }
}
