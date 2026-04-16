using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02.Model
{
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public int MaxAttendees { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //1:M
        public Organizer Organizer { get; set; } = default!;
        public int OrganizerId { get; set; }

        //1:M
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;

        //M:M
        public ICollection<Attendee> Attendees { get; set; } = new HashSet<Attendee>();
    }
}
