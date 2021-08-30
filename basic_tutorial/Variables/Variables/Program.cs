using System;
using System.Collections.Generic;

namespace Variables
{
    class Program
    {
        // Enums
        enum Doctor
        {
            Speciality,
            Phone
        }
        static Doctor mainDoctor;

        static void Main(string[] args)
        {
            // Variables
            int number1 = 7;
            int number2 = 5;
            Console.WriteLine($"The numbers in this console app are: {number1} and {number2}");

            // Functions
            Nothing();
            bool bigger = isBiggerThan(number1, number2);
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

            int[] emptyArray = new int[5];
            int[] arrayNumbers = new int[] { 1, 2, 3, 4, 5 };

            List<int> intList = new List<int>() { 1, 2, 3};
            intList.Add(5);
            intList.Remove(1);

            // Loops
            Console.WriteLine("I'm the array number:");
            foreach (int number in arrayNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("I'm the empty array:");
            foreach (int number in emptyArray)
            {
                Console.WriteLine(number);
            }

            // Fill the empty array with the double of array of number
            for(int i = 0; i < arrayNumbers.Length; i++)
            {
                emptyArray[i] = arrayNumbers[i] * 2;
            }

            Console.WriteLine("I'm the empty array after be filled:");
            foreach (int number in emptyArray)
            {
                Console.WriteLine(number);
            }

            int j = 0;
            while(j++ < 2)
            {
                Console.WriteLine($"While writting...{j}");
            }

            do
            {
                Console.WriteLine($"Do While writting...{j}");
            } while (j++ < 5);

            // Enums
            switch(mainDoctor)
            {
                case Doctor.Phone:
                    break;
                case Doctor.Speciality:
                    break;
            }

            // Classes
            House myFirstHouse = new House();
            myFirstHouse.numRooms = 5;
            bool isClean = myFirstHouse.isClean();
            Console.WriteLine($"Is the house clean? : {isClean}");


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
   
        // Classes
        class House
        {
            public string address;
            public int zipcode;
            public int numRooms;

            public bool isClean()
            {
                return true;
            }
        }
    }
}
