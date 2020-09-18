using CarDriver2.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace CarDriver2
{
    public partial class GameForm : Form
    {
        private int coins = 0;
        private int score = 0;
        private int x, y;
        private int speed = 20;
        private int record = 0;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            pictureBxMyCar.Load($"images\\{FileManager.Load_chosenCar().Name}.png");
            if (Settings.Default.Record != 0)
                labelRecord.Text = Settings.Default.Record.ToString();
            GetPictureOfEnemy();
            GameTimer.Start();
            Random rand = new Random();
            pictureBxEnemy1.Location = new Point(x = rand.Next(0, 160), y = rand.Next(-60, -45));
            pictureBxEnemy2.Location = new Point(x = rand.Next(188, 364), y = rand.Next(-60, -45));
            pictureBxEnemy3.Location = new Point(x = rand.Next(393, 560), y = rand.Next(-60, -45));

            pbCoin1_1.Location = new Point(x = rand.Next(0, 160), y = rand.Next(-3, 102));
            pbCoin1_2.Location = new Point(x = rand.Next(0, 160), y = rand.Next(140, 257));
            pbCoin1_3.Location = new Point(x = rand.Next(0, 160), y = rand.Next(289, 387));
            pbCoin1_4.Location = new Point(x = rand.Next(0, 160), y = rand.Next(416, 527));
            pbCoin1_5.Location = new Point(x = rand.Next(0, 160), y = rand.Next(560, 641));

            pbCoin2_1.Location = new Point(x = rand.Next(188, 364), y = rand.Next(0, 111));
            pbCoin2_2.Location = new Point(x = rand.Next(188, 364), y = rand.Next(140, 258));
            pbCoin2_3.Location = new Point(x = rand.Next(188, 364), y = rand.Next(289, 387));
            pbCoin2_4.Location = new Point(x = rand.Next(188, 364), y = rand.Next(417, 531));

            pbCoin3_1.Location = new Point(x = rand.Next(393, 560), y = rand.Next(-11, 111));
            pbCoin3_2.Location = new Point(x = rand.Next(393, 560), y = rand.Next(150, 256));
            pbCoin3_3.Location = new Point(x = rand.Next(393, 560), y = rand.Next(289, 387));
            pbCoin3_4.Location = new Point(x = rand.Next(393, 560), y = rand.Next(417, 530));
            pbCoin3_5.Location = new Point(x = rand.Next(393, 560), y = rand.Next(560, 641));
        }

        void GetPictureOfEnemy()
        {
            PictureBox[] pb = new PictureBox[] { pictureBxEnemy1, pictureBxEnemy2, pictureBxEnemy3 };

            Random rand = new Random();

            for (int i = 0; i < pb.Length; i++)
            {
                int res = rand.Next(1, 4);
                if (res == 1)
                    pb[i].Image = Properties.Resources.other_car2;
                else
                    if (res == 2)
                    pb[i].Image = Properties.Resources.police;
                else
                    if (res == 3)
                    pb[i].Image = Properties.Resources.taxi;
                else
                    if (res == 4)
                    pb[i].Image = Properties.Resources.embulance;
                pb[i].Visible = true;
            }

        }

        void Road(int speed)
        {
            PictureBox[] r1 = new PictureBox[] { road1, road2, road3, road4, road5, road6, road7, road8, road9, road10, road11 };
            foreach (PictureBox item in r1)
            {
                if (item.Top >= 710)
                {
                    x = 0; y = 0;
                    item.Location = new Point(x = 81, y = -43);
                    item.Visible = true;
                }
                else
                {
                    item.Top += speed;
                }
            }

            PictureBox[] r2 = new PictureBox[] { road20, road21, road22, road23, road24, road25, road27, road28, road29, road30, road31 };
            foreach (PictureBox item in r2)
            {
                if (item.Top >= 710)
                {
                    x = 0; y = 0;
                    item.Location = new Point(x = 285, y = -43);
                    item.Visible = true;
                }
                else
                {
                    item.Top += speed;
                }
            }

            PictureBox[] r3 = new PictureBox[] { road40, road41, road42, road43, road44, road45, road46, road47, road48, road49, road50 };
            foreach (PictureBox item in r3)
            {
                if (item.Top >= 710)
                {
                    x = 0; y = 0;
                    item.Location = new Point(x = 476, y = -43);
                    item.Visible = true;
                }
                else
                {
                    item.Top += speed;
                }
            }
        }

        void GameOver()
        {
            if (pictureBxMyCar.Bounds.IntersectsWith(pictureBxEnemy2.Bounds) || pictureBxMyCar.Bounds.IntersectsWith(pictureBxEnemy3.Bounds) || pictureBxMyCar.Bounds.IntersectsWith(pictureBxEnemy1.Bounds))
            {
                timer1.Enabled = false;
                GameTimer.Enabled = false;

                Settings.Default.Sec += seconds;
                Settings.Default.Min += minutes;
                Settings.Default.Coins += coins;
                Settings.Default.Score += score;

                if (speed > Settings.Default.Speed)
                    Settings.Default.Speed = speed;
                if (score > Settings.Default.Record)
                    Settings.Default.Record = score;

                FileManager.Save_Score(new GameResult(score, coins, speed, minutes, seconds));
                FileManager.Save_TotalScore(new TotalGameInfo(Settings.Default.Record, Settings.Default.Score, Settings.Default.Coins, Settings.Default.Speed, Settings.Default.Min, Settings.Default.Sec));

                this.Hide();
                GameOver gameover = new GameOver();
                gameover.ShowDialog();
                this.Close();
            }

        }
        void collectCoins()
        {
            PictureBox[] pb = new PictureBox[] { pbCoin1_1, pbCoin1_2, pbCoin1_3, pbCoin1_4, pbCoin1_5, pbCoin2_1, pbCoin2_2, pbCoin2_3, pbCoin2_4, pbCoin3_1, pbCoin3_2, pbCoin3_3, pbCoin3_4, pbCoin3_5 };

            for (int i = 0; i < pb.Length; i++)
            {
                if (pictureBxMyCar.Bounds.IntersectsWith(pb[i].Bounds) && pb[i].Visible)
                {
                    coins++;
                    labelCoins.Text = coins.ToString();
                    pb[i].Visible = false;
                }

            }
        }


        void Coin(int speed)
        {
            Random rand = new Random();

            PictureBox[] CoinsOfFirstRoad = new PictureBox[] { pbCoin1_1, pbCoin1_2, pbCoin1_3, pbCoin1_4, pbCoin1_5 };

            foreach (PictureBox pb1 in CoinsOfFirstRoad)
            {
                if (pb1.Top >= 780)
                {
                    x = 0; y = 0;
                    pb1.Location = new Point(x = rand.Next(0, 160), y = -15);
                    pb1.Visible = true;
                }
                else
                {
                    pb1.Top += speed / 2;
                }
            }

            PictureBox[] CoinsOfSecondRoad = new PictureBox[] { pbCoin2_1, pbCoin2_2, pbCoin2_3, pbCoin2_4 };

            foreach (PictureBox pb2 in CoinsOfSecondRoad)
            {
                if (pb2.Top >= 780)
                {
                    x = 0; y = 0;
                    pb2.Location = new Point(x = rand.Next(188, 364), y = -15);
                    pb2.Visible = true;
                }
                else
                {
                    pb2.Top += speed / 2;
                }
            }

            PictureBox[] CoinsOfThirdRoad = new PictureBox[] { pbCoin3_1, pbCoin3_2, pbCoin3_3, pbCoin3_4, pbCoin3_5 };

            foreach (PictureBox pb3 in CoinsOfThirdRoad)
            {
                if (pb3.Top >= 780)
                {
                    x = 0; y = 0;
                    pb3.Location = new Point(x = rand.Next(393, 560), y = -15);
                    pb3.Visible = true;
                }
                else
                {
                    pb3.Top += speed / 2;
                }
            }
        }

        void Enemy(int speed)
        {
            Random rand = new Random();

            if (pictureBxEnemy3.Top >= 775)
            {
                pictureBxEnemy3.Top = -100;
                pictureBxEnemy3.Left = rand.Next(391, 540);
                GetPictureOfEnemy();
            }
            else
            {
                pictureBxEnemy3.Top += speed;
            }


            if (pictureBxEnemy2.Top >= 775)
            {
                pictureBxEnemy2.Top = -100;
                pictureBxEnemy2.Left = rand.Next(191, 347);
                GetPictureOfEnemy();
            }
            else
            {
                pictureBxEnemy2.Top += speed;
            }

            if (pictureBxEnemy1.Top >= 775)
            {
                pictureBxEnemy1.Top = -100;
                pictureBxEnemy1.Left = rand.Next(3, 143);
                GetPictureOfEnemy();
            }
            else
            {
                pictureBxEnemy1.Top += speed;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (pictureBxMyCar.Left > 3)
                {
                    pictureBxMyCar.Left += -speed;
                }
            }
            else
                if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (pictureBxMyCar.Left < 528)
                {
                    pictureBxMyCar.Left += speed;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameOver();
            Coin(speed);
            Enemy(speed);
            Road(speed);
            collectCoins();
        }

        int seconds = 0, minutes = 0;

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (seconds < 59)
            {
                seconds++;

                if (seconds < 10)
                {
                    labelSeconds.Text = "0" + seconds.ToString();
                }
                else
                {
                    labelSeconds.Text = seconds.ToString();
                }
            }
            else
            {
                if (minutes < 59)
                {
                    minutes++;
                    if (minutes < 10)
                    {
                        labelMinutes.Text = "0" + minutes.ToString();
                    }
                    else
                    {
                        labelMinutes.Text = minutes.ToString();
                    }

                    seconds = 0;
                    labelSeconds.Text = "00";
                }
                else
                {
                    minutes = 0;
                    labelMinutes.Text = "00";
                }
            }

            if (seconds % 1 == 0)
            {
                score += 5;
                labelScore.Text = score.ToString();
            }
        }
    }
}
