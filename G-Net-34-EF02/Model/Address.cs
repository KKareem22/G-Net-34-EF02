using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02.Model
{
    internal class Address
    {
        public string Street { get; set; } = default!;
        public string City { get; set; }= default!;
        public string Country { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
    }
}
