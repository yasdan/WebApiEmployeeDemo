using System.ComponentModel.DataAnnotations;
namespace WebApiEmployeeDemo.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Designation { get; set; }
        [DataType(DataType.Date)]
        public DateTime? JoinDate { get; set; }
    }
} 
