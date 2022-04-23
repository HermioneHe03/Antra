using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        public int ThrownTimes { get; set; }
        public void Pop()
        {
            if(Size != 0)
            {
                ThrownTimes++;
            }
        }
        public int GetTimes()
        {
            return ThrownTimes;
        }
    }
}
