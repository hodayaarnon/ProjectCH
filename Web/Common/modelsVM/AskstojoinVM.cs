using System;
using System.Collections.Generic;
using System.Text;

namespace Common.modelsVM
{
   public class AskstojoinVM
    {
        public int Askid { get; set; }
        public string Communityname { get; set; }
        public int? Userid { get; set; }
        public int? Communityid { get; set; }
        public bool? Joinasamanager { get; set; }
    }
}
