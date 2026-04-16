using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02.Model
{
    internal class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = default!;

        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
