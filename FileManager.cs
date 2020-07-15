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
    }
}
