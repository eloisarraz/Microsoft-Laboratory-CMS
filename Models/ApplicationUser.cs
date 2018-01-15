using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MicrosoftLaboratoryCms.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfilePictureUrl { get; set; }
        public DateTime? LastTimeRemoveUncompletedProfile { get; set; }
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        public bool Deleted { get; set; } = false;
        [MaxLength(6)]
        public string Locale { get; set; } = "en/US";
        [MaxLength(255)]
        public string Country { get; set; }
        public string Description { get; set; }
    }
}
