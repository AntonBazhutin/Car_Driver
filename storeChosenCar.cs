using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver2
{
    [Serializable]
    public class storeChosenCar : storeIsBoughtCar
    {
        public storeChosenCar(string name, int cost, bool isBought) : base(name, cost, isBought)
        {

        }
    }
}
