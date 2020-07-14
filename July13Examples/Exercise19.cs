using System;
using System.Collections.Generic;
using System.Text;

namespace July13Examples
{
    class Exercise19
    {        
        public static int SumUserInputs(int valueOne, int valueTwo)
        {            
            var sum = 0;
            for (int i = valueOne; i <= valueTwo; i++)
            {
                sum += i;
            }
            return sum;
        }
    }

}

