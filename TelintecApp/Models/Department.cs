namespace TelintecApp.Models
{
    using System.Collections.Generic;

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentChief { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }

}
