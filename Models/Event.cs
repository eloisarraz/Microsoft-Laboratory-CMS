using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftLaboratoryCms.Models
{
    public class Event
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
        [Required]
        public DateTime EventDateTime { get; set; }
        [Required]
        public ApplicationUser Author { get; set; }
        public List<string> Tags { get; set; }
        public string Corpus { get; set; }
        public string ThumbnailImage { get; set; }
    }
}
