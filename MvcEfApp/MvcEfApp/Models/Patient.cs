using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEfApp.Models
{
    public class Patient
    {
        [Key]//if u use key no need to put required
        public int Id { get; set; }
        [Required]
        [StringLength(20)]//varchar
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 characters")]
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime DateofBirth { get; set; }
        [Column(TypeName = "numeric(18,0)")]
        public decimal PhoneNumber { get; set; }
    }
}
