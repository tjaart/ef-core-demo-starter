using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

namespace EntityFrameworkDemo.Entities
{
    [Table("Departments")]
    public class DepartmentEntity
    {
        [Key]
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        
        public List<EmployeeEntity> DepartmentEmployees { get; set; }
    }
}