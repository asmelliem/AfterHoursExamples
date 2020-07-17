using System;

namespace July16Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);                
            }
            finally
            {
                //For after processing and logic you know won't error out
                Console.WriteLine("Good job");
            }
        }
    }
}
