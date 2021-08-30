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
