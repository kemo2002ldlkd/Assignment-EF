using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EF
{
    public class Department
    {
        public int DeptId { get; set; } // Primary Key
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } 
    }

}
