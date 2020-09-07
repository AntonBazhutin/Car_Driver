using System;

namespace CarDriver2
{
    [Serializable]
    public class purchasedItems
    {
        public bool Blue
        {
            get; set;
        }
        public bool Green
        {
            get; set;
        }
        public bool Yellow
        {
            get; set;
        }
        public bool Red
        {
            get; set;
        }
        public purchasedItems(bool blue, bool green, bool yellow, bool red)
        {
            Blue = blue;
            Green = green;
            Yellow = yellow;
            Red = red;
        }
    }
}
