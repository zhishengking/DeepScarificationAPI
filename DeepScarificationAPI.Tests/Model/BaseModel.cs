using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepScarificationAPI.Tests.Model
{
   public  class BaseModel
    {
        public Dictionary<string, string> Params { get; set; }
        //public PageIndex PageObj { get; set; }
        public int TotalCount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public USERINFO Userinfo { get; set; }
    }
}
