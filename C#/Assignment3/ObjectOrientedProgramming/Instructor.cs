using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Instructor: Person
    {
        public int Id { get; set; }
        public Department Department { get; set; }
        public DateTime JoinDate;
        public int Experience
        {
            get { return DateTime.Now.Year - JoinDate.Year; }
        }
    }
}
