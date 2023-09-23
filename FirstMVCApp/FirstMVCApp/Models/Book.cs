using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Book
    {
        //[]-> Annotation or validators
        //the fields of class are decaratd by annotation
        //each data type we have validaton 
        //data anno-for adding
        //use any .net app
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { set; get; }
        [StringLength(25, ErrorMessage = "Title must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Title must have at least 3 chars")]
        [Required(ErrorMessage = "Title is Required")]
        public String Title { set; get; }
        [Range(50, 10000, ErrorMessage = "Cost must be between 50 and 10000")]
        public float Cost { set; get; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public String AuthorName { set; get; }
    }
}
