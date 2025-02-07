using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_EF
{
   
        public class Student
        {
            public int ID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }

            // Foreign Key
            public int Dep_Id { get; set; }

            // Many Students → One Department
            public Department Department { get; set; }
        }

    }

