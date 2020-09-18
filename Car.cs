using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver2
{
    public class Car
    {
        public string Name
        {
            get; set;
        }
        public float Speed
        {
            get; set;
        }
        public float RightMove
        {
            get; set;
        }
        public float LeftMove
        {
            get; set;
        }

        public Car(string name, float speed, float rightMove, float leftMove)
        {
            Name = name;
            Speed = speed;
            RightMove = rightMove;
            LeftMove = leftMove;
        }

        public Car()
        {
            Name = "";
            Speed = 0;
            RightMove = 0;
            LeftMove = 0;
        }
    }
}
