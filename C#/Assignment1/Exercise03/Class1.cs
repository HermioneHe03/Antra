using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Class1
    {
        public void FizzBuzzis(int a = 100)
        {
           for( int i = 1; i <= a; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine($"{i}");
            }
            
        }

        public void Test2()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void GuessNumber()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.Write("Please enter a number you guess between 1 and 3 ==> ");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            if (correctNumber == guessedNumber) Console.WriteLine("Correct answer!");
            else if (guessedNumber < 1 || guessedNumber > 3)  Console.WriteLine("Your guess is outside of the range.");
            else if (correctNumber < guessedNumber) Console.WriteLine("Your guess is too high.");
            else Console.WriteLine("Your guess is too low.");
            
        }

        public void PrintaPyramid(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j <= size - i; j++) Console.Write(" ");
                for (int j = 1; j < i * 2; j++) Console.Write("*");
                Console.WriteLine();
            }
        }

        public void DaysOld()
        {
            Console.Write("Please enter the year that you were born => ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the month that you were born => ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the day that you were born => ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime DateOfBirth = new DateTime(year, month, day);
            double diff = (DateTime.Today - DateOfBirth).TotalDays;
            Console.WriteLine($"You have been lived for {diff} days.");
            int daysToNextAnniversary = Convert.ToInt32(10000 - (diff % 10000));
            Console.WriteLine($"There are {daysToNextAnniversary} days left to your next Anniversary");
        }

        public void Greetings()
        {
            DateTime moment = DateTime.Now;
            int hour = moment.Hour;
            if (hour >=6 && hour < 12) Console.WriteLine("Good Morning");
            else if (hour >= 12 && hour < 17) Console.WriteLine("Good Afternoon");
            else if (hour >= 17 && hour < 23) Console.WriteLine("Good Evening");
            else Console.WriteLine("Good Night");
        }

        public void CountByIncrement(int target = 24)
        {
            for (int i = 1; i <= 4; i++)
            {
                int res = 0;
                while (res <= target)
                {
                    Console.Write($"{res} ");
                    res = res + i;
                }
                Console.WriteLine();
            }
        }
    }
}
