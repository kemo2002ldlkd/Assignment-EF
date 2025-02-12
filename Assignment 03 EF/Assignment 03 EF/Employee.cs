using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EF
{
    public class Employee
    {
        public int Id { get; set; }  // Primary Key
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public int? DepartmentId { get; set; } // Foreign Key (Nullable for employees with no department)
        public Department Department { get; set; } // Navigation Property
    }

}
