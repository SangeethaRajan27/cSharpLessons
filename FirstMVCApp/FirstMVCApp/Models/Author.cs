using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Annotations are to be written in above the variable declaration
        public int AuthorID { set; get; }

        [StringLength(25, ErrorMessage = "AuthorName must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "AuthorName must have at least 3 chars")]
        [Required(ErrorMessage = "AuthorName is Required")]
        public String AuthorName { set; get; }

        [Required(ErrorMessage = "Date of Birth is Required")]
        public DateTime AuthorDateofBirth { set; get; }

        [Range(1, int.MaxValue, ErrorMessage = "Number of Books Published must be at least 1")]
        [Required(ErrorMessage = "Number of Books Published is Required")]
        public String NoofBooksPublished { set; get; }

        [StringLength(50, ErrorMessage = "Royalty Company Name must not have more than 50 characters.")]
        [MinLength(3, ErrorMessage = "Royalty Company Name must have at least 3 characters.")]
        public String Royaltycompany { set; get; }
    }
}
