using CarDriver2.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarDriver2
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            //labelStore.Parent = pictureBox1;
            //labelStore.BackColor = Color.Transparent;

            Label[] ll = new Label[] { label1, label10, label12, label13, label14, label2, label3, label4, label5, label6, label8, label9, labelHighestSpeed, labelLastCarSkin, labelLastCoins, labelLastGameInfo
            ,labelLastMinutes,labelLastScore,labelLastSeconds,labelLastSpeed,labelRecord,labelTotalCoins,labelTotalMin,labelTotalScore,labelTotalSec};

            foreach (var item in ll)
            {
                item.Parent = pictureBox1;
                item.BackColor = Color.Transparent;
            }

            pbLastCar.Load($"images\\{FileManager.Load_Score().NameOfCar}.png");

            labelLastCoins.Text = FileManager.Load_Score().Coins.ToString();
            labelLastScore.Text = FileManager.Load_Score().Score.ToString();
            labelLastSpeed.Text = FileManager.Load_Score().Speed.ToString();

            if (DataSaver.LastGameInfo.Sec > 9)
                labelLastSeconds.Text = DataSaver.LastGameInfo.Sec.ToString();
            else
                labelLastSeconds.Text = "0" + DataSaver.LastGameInfo.Sec.ToString();
            if (DataSaver.LastGameInfo.Min > 9)
                labelLastMinutes.Text = DataSaver.LastGameInfo.Min.ToString();
            else
                labelLastMinutes.Text = "0" + DataSaver.LastGameInfo.Min.ToString();

            if (Settings.Default.Sec > 9)
                labelTotalSec.Text = Settings.Default.Sec.ToString();
            else
                labelTotalSec.Text = "0" + Settings.Default.Sec.ToString();

            if (Settings.Default.Min > 9)
                labelTotalMin.Text = Settings.Default.Min.ToString();
            else
                labelTotalMin.Text = "0" + Settings.Default.Min.ToString();

            labelTotalCoins.Text = DataSaver.totalGameInfo.Coins.ToString();
            labelTotalScore.Text = DataSaver.totalGameInfo.Score.ToString();
            labelRecord.Text = DataSaver.totalGameInfo.Record.ToString();
            labelHighestSpeed.Text = DataSaver.totalGameInfo.Speed.ToString();

            if (Settings.Default.Sec > 59)
            {
                if (Settings.Default.Min + Settings.Default.Sec / 60 > 9)
                    labelTotalMin.Text = (Settings.Default.Min + Settings.Default.Sec / 60).ToString();
                else
                    labelTotalMin.Text = "0" + (Settings.Default.Min + Settings.Default.Sec / 60).ToString();

                if (Settings.Default.Sec % 60 > 9)
                    labelTotalSec.Text = (Settings.Default.Sec % 60).ToString();
                else
                    labelTotalSec.Text = "0" + (Settings.Default.Sec % 60).ToString();
            }

            Label[] lb = new Label[] { labelHighestSpeed, labelLastCarSkin, labelLastCoins, labelLastGameInfo,
                    labelLastMinutes, labelLastScore, labelLastSeconds, labelLastSpeed, labelRecord, labelTotalCoins,
                    labelTotalMin, labelTotalScore, labelTotalSec,label1,label10,label12,label13,label14,label2,label3,label4,label5,label6,label8,label9};

            foreach (var item in lb)
            {
                item.Parent = pictureBox1;
                item.BackColor = Color.Transparent;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void btnBack_MouseLeave_1(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Gray;
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalCoins_Click(object sender, EventArgs e)
        {

        }
    }
}
