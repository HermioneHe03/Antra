using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    internal interface IInstructorService: IPersonService
    {
        public decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
