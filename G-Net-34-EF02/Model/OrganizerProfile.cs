using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02.Model
{
    //using Data Annotations 
    [Table("Profiles")]
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string Bio { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoPhoto { get; set; }

        [ForeignKey("ProfileOwner")]
        public int OrganizerId { get; set; }
        //Navigation Property
        public Organizer ProfileOwner { get; set; } = default!;
    }
}
