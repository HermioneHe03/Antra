using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Class1
    {
        public int[] GenerateNumbers(int n)
        {
            int[] numbers = new int[n];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(int.MinValue, int.MaxValue);
            }
            return numbers;
        }

        public void Revese(int[] array)
        {
            for (int i = 0, j = array.Length-1; i < j; i++, j--)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        public void PrintNumbers(int[] numbers)
        {
            foreach(var number in numbers)
            {
                Console.WriteLine(number + " ");
            }
        }

        public int Fibonacci(int i)
        {
            if (i <= 2)
            {
                return 1;
            }
            int a = 1, b = 1, c = 0;
            for (int j = 3; j <= i; j++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }



        



    }
}
