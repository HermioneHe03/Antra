using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Person
    {
        public int Id { get; set; }
        public decimal Salary
        {
            get { return Salary; }
            set { if(value>0) Salary = value; }
        }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }
        public List<string> Address { get; set; }
        public void GetAddress(List<string> Address)
        {
            foreach(string s in Address)
            {
                Console.WriteLine(s);
            }
        }
    }
}
