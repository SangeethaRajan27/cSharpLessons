using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEfApp.Models
{
    public class Doctor
    {
        [Key]//if u use key no need to put required
        [Column("doctorno")]//in table it would show "doctorno" if not given it choose defaulty as "Id"
        public int Id { get; set; }
        [Required]
        [StringLength(20)]//varchar
        [MinLength(3,ErrorMessage ="Name must be between 3 and 20 characters")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public decimal PhoneNumber { get; set; }
    }
}
