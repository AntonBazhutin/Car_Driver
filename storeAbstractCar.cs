using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver2
{
    [Serializable]
    public abstract class storeAbstractCar
    {
        public string Name
        {
            get; set;
        }

        public int Cost
        {
            get; set;
        }
        public storeAbstractCar(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
