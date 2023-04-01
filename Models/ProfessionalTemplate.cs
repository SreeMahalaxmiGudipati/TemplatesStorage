using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemplatesStorage.Models
{
    public class ProfessionalTemplate
    {
        [Key]
         public int Id { get; set; }
          [Column(TypeName = "text")]
        public string Templates { get; set; }

        [Column(TypeName = "text")]
        public string OriginalTemplates { get; set; }
    }
}