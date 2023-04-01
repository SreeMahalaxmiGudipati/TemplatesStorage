using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemplatesStorage.Models
{
    public class Template
    {

        [Key]
         public int Id { get; set; }
          [Column(TypeName = "text")]
        public string Templates { get; set; }

        [Column(TypeName = "text")]
        public string OriginalTemplates { get; set; }

    }
}