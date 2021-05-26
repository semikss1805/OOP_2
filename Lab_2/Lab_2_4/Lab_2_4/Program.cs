using System;

namespace Lab_2_4
{
    class Program
    {
        public delegate double Del(double a, double r);
        static void Main(string[] args)
        {
            double a = 1;
            double r = 2;
            Del del1 = FirstSum;
            Console.WriteLine(del1(a, r));
            Del del2 = SecondSum;
            Console.WriteLine(del2(a, r));
            Del del3 = ThirdSum;
            Console.WriteLine(del3(a, r));
            del3.Invoke(a, r);
            Console.ReadKey();
        }
        private static double FirstSum(double a, double r)
        {
            double sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += a;
                a /= r;
            }
            return Math.Round(sum, 2);
        }
        private static double SecondSum(double a, double r)
        {
            double sum = 0;
            for (double i = 1; i <= 10; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return Math.Round(sum, 2);
        }

        private static double ThirdSum(double a, double r)
        {
            double sum = 0;
            r *= -1;
            for (int i = 1; i <= 20; i++)
            {
                sum += a;
                a /= -r;
            }
            return Math.Round(sum, 2);
        }
        private static double Factorial(double num)
        {
            double res = 1;
            for (double i = num; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }

    }
}
