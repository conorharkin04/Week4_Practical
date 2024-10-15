using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_prac
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            double result = 0;
            try
            {
                result = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred. {ex.Message}");
            }
            return a/b;
        }
    }
}