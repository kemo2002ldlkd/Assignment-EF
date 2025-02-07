using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_EF
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Top_ID { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; }
    }

}
