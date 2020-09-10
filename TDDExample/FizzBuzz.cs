using System;
using System.Collections.Generic;
using System.Text;

namespace TDDExample
{
    public class FizzBuzz
    {
        public string DetermineFizzBuzzOutput(int input)
        {
            if(input % 5 == 0 && input % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if(input %5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "Fizz";
            }            
        }
    }
}
