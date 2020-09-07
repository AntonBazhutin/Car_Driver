using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver2
{
    [Serializable]
    public class storeIsBoughtCar : storeAbstractCar
    {
        public bool Isbought
        {
            get;set;
        }
        public storeIsBoughtCar(string name,int cost,bool isbought) : base(name,cost)
        {
            Isbought = isbought;
        }
    }
}
