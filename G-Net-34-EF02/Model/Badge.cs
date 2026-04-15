using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02.Model
{
    internal class Badge
    {
        public int BadgeId { get; set; }
        public int BadgeNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public Tier tier { get; set; }

        public int AttendeeId { get; set; }//by Convention 
        public Attendee Attendee { get; set; } = default!;//Auto-discovered from navigation properties and FK properties
    }
}
