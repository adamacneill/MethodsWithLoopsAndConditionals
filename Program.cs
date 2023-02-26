using System;
using System.ComponentModel;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRange(1000, -1000);
            VotingAge();
            EvenOdd();
            PosNeg();
            InRange();
            MulTable();
        }


        //Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two intergers as parameters and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        static void VotingAge()
        {
            int votingAge;

            Console.WriteLine("Please input the age of the voting party :");
            votingAge = Convert.ToInt32(Console.ReadLine());

            if (votingAge < 18)
            {
                Console.WriteLine("You're too young this time!");
            }

            else
            {
                Console.WriteLine("You are old enough to vote");
            }

        }
        //Write a method to check whether a given number is even or odd
        static void EvenOdd()
        {
            int i;

            Console.WriteLine("Enter a Number:");

            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("That number is even!");
            }

            else

            {
                Console.Write("That number is odd!");
            }
        }
        //Write a method to check whether a given number is positive or negative
        static void PosNeg()
        {
            int b;

            Console.WriteLine("Give me a number to determine whether it is negative or positive");

            b = int.Parse(s: Console.ReadLine());

            if (b > 0)
            {
                Console.WriteLine("This number is positive!");
            }

            else if (b == 0)
            {
                Console.WriteLine("This number is zero. Neither negative or positive.");
            }
            else
            {
                Console.WriteLine("This number is negative!");
            }

        }

        // Write a method to check if an integer(from the user) is in the range -10 to 10
        static void InRange()
        {
            int a;

            Console.WriteLine("Give me a number to determine whether you are in my number range:");

            a = int.Parse(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine("Too high to be in range!");
            }

            else if (a < -10)
            {
                Console.WriteLine("Too low to be in range!");
            }
            else
            {
                Console.WriteLine("You are within my range!");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MulTable()
        {
            int i, num;

            Console.WriteLine("Give me a number for a multiplication table:");

           num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2} \n", num, i, num * i);
            }
        }
    }
}