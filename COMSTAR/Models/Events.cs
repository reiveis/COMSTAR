using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace COMSTAR.Models
{
    public partial class Events
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTarget { get; set; }
        public string EventDescription { get; set; }
        public byte[] EventImage { get; set; }
    }
}
 