using System;

namespace FizzBuzzExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 100;
            int i = 1;
            while (i <= Number){
                Console.WriteLine(i + (i % 3 == 0 ? " Fizz": (i % 5 == 0 ? " Buzz": "")));
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                i++;
            }
        }
    }
}
