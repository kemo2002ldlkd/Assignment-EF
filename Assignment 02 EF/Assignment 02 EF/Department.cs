using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_EF
{
   
        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Ins_ID { get; set; }
            public DateTime HiringDate { get; set; }

            //  One Department → Many Students
            public ICollection<Student> Students { get; set; }
        }
    }

