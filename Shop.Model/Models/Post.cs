using Shop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Post")]
    public class Post : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(500)]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }

        [ForeignKey("CategoruID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}