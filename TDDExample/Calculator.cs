using System;
using System.Collections.Generic;
using System.Text;

namespace TDDExample
{
    public class Calculator
    {
        public double Addition(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public double Subtraction(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public double Divide(int numberOne, int numberTwo)
        {
            try
            {
                return numberOne / numberTwo;
            }
            catch
            {
                throw new Exception();
            }
            
        }

        public double Multiply(int numberOne, int numberTwo)
        {

            return numberOne * numberTwo;
        }
    }
}
