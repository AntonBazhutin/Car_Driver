using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarDriver2
{
    public static class FileManager
    {
        public static void Save_Score(GameResult result)
        {
            DataSaver.LastGameInfo = result;
            BinaryFormatter bf = new BinaryFormatter();

            using (StreamWriter sw = new StreamWriter("score.dat"))
            {
                bf.Serialize(sw.BaseStream, result);
            }
        }

        public static GameResult Load_Score()
        {
            GameResult result = null;

            if (File.Exists("score.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();

                using (StreamReader sw = new StreamReader("score.dat"))
                {
                    result = (GameResult)bf.Deserialize(sw.BaseStream);
                    DataSaver.LastGameInfo = result;
                }
            }
            return result;
        }
        public static void Save_TotalScore(TotalGameInfo result)
        {
            DataSaver.totalGameInfo = result;
            BinaryFormatter bf = new BinaryFormatter();

            using (StreamWriter sw = new StreamWriter("score_2.dat"))
            {
                bf.Serialize(sw.BaseStream, result);
            }
        }

        public static TotalGameInfo Load_TotalScore()
        {
            TotalGameInfo result = null;

            if (File.Exists("score_2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();

                using (StreamReader sw = new StreamReader("score_2.dat"))
                {
                    result = (TotalGameInfo)bf.Deserialize(sw.BaseStream);
                    DataSaver.totalGameInfo = result;
                }
            }
            return result;
        }

        public static void Save_Items(purchasedItems result)
        {
            DataSaver.getItems = result;
            BinaryFormatter bf = new BinaryFormatter();

            using (StreamWriter sw = new StreamWriter("purchasedItems.dat"))
            {
                bf.Serialize(sw.BaseStream, result);
            }
        }
        public static purchasedItems Load_Items()
        {
            purchasedItems result = null;

            if (File.Exists("purchasedItems.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();

                using (StreamReader sw = new StreamReader("purchasedItems.dat"))
                {
                    result = (purchasedItems)bf.Deserialize(sw.BaseStream);
                    DataSaver.getItems = result;
                }
            }
            return result;
        }
    }
}
