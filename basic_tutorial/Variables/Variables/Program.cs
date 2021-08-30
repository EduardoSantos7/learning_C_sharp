using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int number1 = 7;
            int number2 = 5;
            Console.WriteLine($"The numbers in this console app are: {number1} and {number2}");

            // Functions
            Nothing();
            bool bigger = isBiggerThan(5, 7);
            Console.WriteLine($"{number1} > {number2}: " + bigger);

            // Conditions
            if (bigger)
            {
                Console.WriteLine($"{number1} is bigger");
            }
            else
            {
                Console.WriteLine($"{number2} is bigger");
            }

            if(bigger && number1 > 0)
            {
                Console.WriteLine($"{number1} I'm bigger but also positive");
            }

            switch(number1)
            {
                case 0:
                    Console.WriteLine("I'm zero");
                    break;
                default:
                    Console.WriteLine("I'm not zero");
                    break;
            }
        }

        // Function returning nothing
        static void Nothing()
        {
            Console.WriteLine("No returning data");
        }

        static bool isBiggerThan(int number, int target)
        {
            return number > target;
        }
    }
}
