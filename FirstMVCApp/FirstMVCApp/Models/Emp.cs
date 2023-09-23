using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Annotations are to be written in above the variable declaration
        public int Id { set; get; }
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage = "Name must be between 3 and 20 chars")]
        public String Name { set; get; }
        [Range(10000,500000)]
        public Decimal Salary { set; get; }
        [Required]
        [StringLength(20, ErrorMessage = "City Name must be between 3 and 20 chars")]
        public String City { set; get; }
    }
}
