using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftLaboratoryCms.Models
{
    public class ArticleArticleCategory
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string ArticleId { get; set; }
        [Required]
        [ForeignKey("ArticleId")]
        public Article Article { get; set; }

        [Required]
        public string ArticleCategoryId { get; set; }
        [Required]
        [ForeignKey("ArticleCategoryId")]
        public ArticleCategory ArticleCategory { get; set; }
    }
}
