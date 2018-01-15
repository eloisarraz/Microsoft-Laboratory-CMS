using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftLaboratoryCms.Models
{
    public class ArticleCategory
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ArticleArticleCategory> Articles { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
