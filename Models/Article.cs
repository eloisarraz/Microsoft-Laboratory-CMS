using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftLaboratoryCms.Models
{
    public class Article
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Corpus { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public ApplicationUser Author { get; set; }
        public string ThumbnailImage { get; set; }
        public List<ArticleArticleCategory> ArticleCategories { get; set; }
    }
}
