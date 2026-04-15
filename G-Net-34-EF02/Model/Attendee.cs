using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02.Model
{
    internal class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string? Email { get; set; }
        public Address Address { get; set; } = new Address();

        public Badge? Badge { get; set; }//Auto-discovered from navigation properties and FK properties
    }
}
