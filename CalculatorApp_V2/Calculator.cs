using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_V2
{
    class Calculator
    {
        //public double firstNumber;
        //public double secondNumber;
        //public double result;

        //does
        public double Add(double firstNumber ,double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return Math.Abs(firstNumber - secondNumber);
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber*secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber/secondNumber;
        }

        //public double GetResult(string operation)
        //{
         
        //}

    }
}
