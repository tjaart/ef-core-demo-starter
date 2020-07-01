using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Entities
{
    [Table("Employees")]
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }
        
        
        public string Fullname { get; set; }

        public DepartmentEntity Department { get; set; }
    }
}