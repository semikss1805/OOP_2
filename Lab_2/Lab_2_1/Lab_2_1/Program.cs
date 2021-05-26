using System;
using System.Collections.Generic;

namespace Lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage gr = new Garage(new Car[]{ new Car(), new Car(), new Car() });
            Washer ws = new Washer();
            Action<Car> wash = ws.Wash;

            foreach (var car in gr)
            {
                wash(car);
            }
        }
    }
}
