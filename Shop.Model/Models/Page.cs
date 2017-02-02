using Shop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Pages")]
    public class Page : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        public string Content { set; get; }

        [Column(TypeName = "Varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
    }
}