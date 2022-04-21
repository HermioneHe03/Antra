using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class Class1
    {
        public void ConvertTime(uint century)
        {
            uint year = century * 100;
            uint day = year * 365;
            uint hour = day * 24;
            ulong minute = hour * 60;
            ulong second = minute * 60;
            ulong millisecond = second * 1000;
            ulong microsecond = millisecond * 1000;
            ulong nanosecond = microsecond * 1000;
            Console.WriteLine($"{century} centuries = {year} years = {day} days = {hour} hours = {minute} minutes = {second} seconds = {millisecond} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds");

        }
    }
}
