using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_EF
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRateBonus { get; set; }
        public int Dept_ID { get; set; }

        
        public ICollection<Course_Inst> Course_Insts { get; set; }
    }

}
