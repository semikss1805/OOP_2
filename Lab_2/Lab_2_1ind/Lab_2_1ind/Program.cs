using System;

namespace Lab_2_1ind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 -- sqrt(abs(x))");
            Console.WriteLine("1 x -- x^3");
            Console.WriteLine("2 x-- x + 3.5");
          
            Func<double, double> options =  x => Math.Sqrt(Math.Abs(x));

            try
            {
                while (true)
                {
                    string[] input = Console.ReadLine().Trim().Split();
                    int idx = int.Parse(input[0]);
                    double x = double.Parse(input[1]);
                    Console.WriteLine(options(x));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
