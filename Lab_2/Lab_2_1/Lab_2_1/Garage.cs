using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1
{
    class Garage
    {
        private Car[] cars;
        public Garage(Car[] cars)
        {
            this.cars = cars;
        }
        public IEnumerator<Car> GetEnumerator()
        {
            return ((IEnumerable<Car>)cars).GetEnumerator();
        }
    }
}
