using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Department
    {
        public string DName { get; set; }
        
        public decimal Budget { get; set; }
        public int HeadID { get; set; }
        public List<Course> SupportCourses { get; set; }

    }
}
