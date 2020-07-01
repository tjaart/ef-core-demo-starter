using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Entities
{
    [Table("DepartmentManagers")]
    public class DepartmentManagerEntity
    {
        [Key]
        public int Id { get; set; }
        
        // navigation property
        
        [ForeignKey(nameof(EmployeeId))]
        public EmployeeEntity Employee { get; set; }
        
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        
        [ForeignKey(nameof(DepartmentId))]
        public DepartmentEntity Department { get; set; }
    }
}