using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver2
{
    [Serializable]
    public class GameResult
    {
        private int score;
        private int coins;
        private int speed;
        private int min;
        private int sec;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public int Coins
        {
            get { return coins; }
            set { coins = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        public int Sec
        {
            get { return sec; }
            set { sec = value; }
        }

        public GameResult(int score, int coins, int speed, int min, int sec)
        {
            Score = score;
            Coins = coins;
            Speed = speed;
            Min = min;
            Sec = sec;
        }
    }
}
