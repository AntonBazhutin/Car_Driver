using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver2
{
    public static class DataSaver
    {
        public static GameResult LastGameInfo { get; set; }
        public static TotalGameInfo totalGameInfo { get; set; }

        public static purchasedItems getItems { get; set; }
    }
}
