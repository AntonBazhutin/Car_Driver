using CarDriver2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDriver2
{
    [Serializable]
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.White;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Gray;
        }

        private void Score_Load(object sender, EventArgs e)
        {
            labelLastCoins.Text = DataSaver.LastGameInfo.Coins.ToString();
            labelLastScore.Text = DataSaver.LastGameInfo.Score.ToString();

            if (int.Parse(labelSeconds.Text) > 9)
                labelSeconds.Text = DataSaver.LastGameInfo.Sec.ToString();
            else
                labelSeconds.Text = "0" + DataSaver.LastGameInfo.Sec.ToString();
            if (int.Parse(labelMinutes.Text) > 9)
                labelMinutes.Text = DataSaver.LastGameInfo.Min.ToString();
            else
                labelMinutes.Text = "0" + DataSaver.LastGameInfo.Min.ToString();
            labelLastSpeed.Text = DataSaver.LastGameInfo.Speed.ToString();

            labelTotalCoins.Text = Settings.Default.Coins.ToString();
            labelTotalScore.Text = Settings.Default.Score.ToString();
        }
    }
}
