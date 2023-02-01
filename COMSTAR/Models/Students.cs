using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSTAR.Models
{
    public class Students
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public int Section { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
