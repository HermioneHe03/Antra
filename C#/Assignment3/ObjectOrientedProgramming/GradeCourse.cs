using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public enum Grade { A, B, C, D, E, F }
    public class GradeCourse
    {
        
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Grade Grade { get; set; }
        public double CalculateGPA()
        {
            throw new NotImplementedException();
        }
    }
}
