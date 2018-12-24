using System;

namespace Calculator
{
    public class Calculator
    {
        public static double Additioning(double num, double num1)
        {
            return num + num1;
        }

        public static double Substraction(double num, double num1)
        {
            return num - num1;
        }

        public static double Division(double num, double num1)
        {
            return num/num1;
        }

        public static double Multiplication (double num, double num1)
        {
            return num * num1;
        }

        public static double PowerOfTwo(double num)
        {
            return num * num ;
        }

        public static double Squarerooting(double num)
        {
            num = Math.Sqrt(num);
            return num;
        }
    }
}
