using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02.Model
{
    //using Data Annotations 
    [Table("Organizers")]
    internal class Organizer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        
        //Navigation Property
        public OrganizerProfile Profile { get; set; } = default!;

        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
