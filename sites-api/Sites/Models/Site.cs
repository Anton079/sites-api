using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sites_api.Sites.Models
{
    [Table("site")]
    public class Site
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [Column("pageNumber")]
        public int PageNumber { get; set; }

        [Required]
        [Column("price")]
        public int Price { get; set; }
    }
}
