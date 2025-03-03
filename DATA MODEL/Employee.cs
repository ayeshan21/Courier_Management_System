using System.ComponentModel.DataAnnotations;

namespace Courier_Management_System.DATA_MODEL
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? NID { get; set; }
        [Required]
        public string? EID { get; set; }
       
    }
}
