using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            // get 20 random numbers from 1-50
            Random random = new Random();
            var numbers = new List<int>();
            var sqnumbers = new List<int>();
            var evenNumbers = new List<int>();

            var firstSet = "";
            int randomNumber = random.Next(0, 50);
            for (int ctr = 0; ctr <= 19; ctr++)
            {
                numbers.Add(random.Next(50));
            }
            firstSet = string.Join(", ", numbers);
            Console.WriteLine("Below are the random 20 numbers.");
            Console.WriteLine(firstSet);

            // square each of those 20 numbers in the list
            var final = 1;
            var dope = 1;
            var go = "";
            var numberList = "";
            foreach (var number in numbers)
            {
                var finalInt = number;
                final = finalInt;
                dope = final *= finalInt;
                sqnumbers.Add(dope);
                numberList = string.Join(", ", sqnumbers);
            }
            Console.WriteLine("Here the numbers are squared");
            Console.WriteLine(numberList);

            // take out the odd numbers

            var onlyEvenNumbers = sqnumbers.Where(num => num % 2 == 0);
            Console.WriteLine("Here are only the even numbers from the squared list");
            Console.WriteLine(string.Join(", ", onlyEvenNumbers));
            Console.ReadLine();
        }
    }
}
