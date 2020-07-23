using System;

namespace MockAssessment1a
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"4 and 4 is the same? {IsTheSame(4, 4)}");
            Console.WriteLine($"5 and 4 is the same? {IsTheSame(5, 4)}");
            Console.WriteLine($"5.5 - 1.2 = {Subtract(1.2, 5.5)}");
            Console.WriteLine($"Building Type <= 3 is {FindBuildingType(2)}");
            Console.WriteLine($"Building Type between 4 and 10 is {FindBuildingType(7)}");
            Console.WriteLine($"Building Type between 11 and 49 is {FindBuildingType(26)}");
            Console.WriteLine($"Building Type over 50 is {FindBuildingType(62)}");

        }

        public static bool IsTheSame(int numOne, int numTwo)
        {
            if(numOne == numTwo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Subtract(double numOne, double numTwo)
        {
            return numTwo - numOne;
        }

        public static string FindBuildingType(int num)
        {

            if (num <= 3)
            {
                return "This is a house!";
            }
            if(num >= 4 && num <= 10)
            {
                return "This is an office building!";
            }
            else if (num >= 11 && num <= 49)
            {
                return "This is a skyscraper!";
            }
            else
            {
                return "This is a SUPER skyscraper!";
            }            
        }


    }
}
