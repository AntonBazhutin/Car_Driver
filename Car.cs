using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver2
{
    [Serializable]
    class Car
    {
        public int Cost
        {
            get; set;
        }
        public string NameOfCar
        {
            get; set;
        }
        public Car(string nameOfCar, int cost)
        {
            Cost = cost;
            NameOfCar = nameOfCar;
        }
    }
}
