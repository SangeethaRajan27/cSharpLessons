using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace FirstMVCApp.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Annotations are to be written in above the variable declaration
        public int Id { set; get; }
        [Required]
        [MaxLength(255)]
        public String Title { set; get; }
        [Required]
        [MaxLength(50)]
        public String Language { set; get; }
        [Required]
        [MaxLength(50)]
        public String Hero { set; get; }
        [Required]
        [MaxLength(50)]
        public String Director { set; get; }
        [Required]
        [MaxLength(50)]
        public String MusicDirector { set; get; }
        public DateTime ReleaseDate { set; get; }

        [Column(TypeName = "decimal(10, 2)")]
        public Decimal Cost { set; get; }

        [Column(TypeName = "decimal(10, 2)")]
        public Decimal Collection { set; get; }
        [MaxLength(255)]
        public String Review { set; get; }
    }
}