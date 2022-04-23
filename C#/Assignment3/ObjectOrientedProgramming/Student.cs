using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Student: Person
    {
        public int StudentId { get; set; }
        public List<Course> EnrolledCourses { get; set; }

    }
}
