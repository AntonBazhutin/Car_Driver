using CarDriver2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CarDriver2
{
    public partial class MainMenu : Form
    {
        WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        public MainMenu()
        {
            InitializeComponent();
            mediaPlayer.URL = "theme_song.mp3";
            mediaPlayer.enabled = true;

        }

        bool clicked = false;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop();
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop();
            this.Close();
        }

        private void btnPlay_MouseMove(object sender, MouseEventArgs e)
        {
            btnPlay.BackColor = Color.White;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.Gray;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnGarage.BackColor = Color.Gray;
        }

        private void btnSettings_MouseMove(object sender, MouseEventArgs e)
        {
            btnGarage.BackColor = Color.White;
        }

        private void btnScore_MouseLeave(object sender, EventArgs e)
        {
            btnScore.BackColor = Color.Gray;
        }

        private void btnScore_MouseMove(object sender, MouseEventArgs e)
        {
            btnScore.BackColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Gray;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.BackColor = Color.White;
        }

        private void btnVolumeOnOff_MouseLeave(object sender, EventArgs e)
        {
            btnVolumeOnOff.BackColor = Color.Gray;
        }

        private void btnVolumeOnOff_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolumeOnOff.BackColor = Color.White;
        }

        private void btnVolumeOnOff_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                btnVolumeOnOff.Image = Properties.Resources.volumeOff;
                mediaPlayer.controls.pause();
                clicked = true;
            }
            else
            {
                btnVolumeOnOff.Image = Properties.Resources.volumeOn;
                mediaPlayer.controls.play();
                clicked = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("score_2.dat") && File.Exists("score.dat"))
            {
                FileManager.Load_Score();
                FileManager.Load_TotalScore();
                Settings.Default.Coins = FileManager.Load_TotalScore().Coins;
                Settings.Default.Score = FileManager.Load_TotalScore().Score;
                Settings.Default.Record = FileManager.Load_TotalScore().Record;
                Settings.Default.Speed = FileManager.Load_TotalScore().Speed;
                Settings.Default.Min = FileManager.Load_TotalScore().Min;
                Settings.Default.Sec = FileManager.Load_TotalScore().Sec;
            }
        }

        private void btnStore_MouseMove(object sender, MouseEventArgs e)
        {
            btnStore.BackColor = Color.White;
        }

        private void btnStore_MouseLeave(object sender, EventArgs e)
        {
            btnStore.BackColor = Color.Gray;
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop();
            this.Hide();
            Store str = new Store();
            str.ShowDialog();
            this.Close();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop();
            this.Hide();
            Score score = new Score();
            score.ShowDialog();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop();
            this.Hide();
            Garage garage = new Garage();
            garage.ShowDialog();
            this.Close();
        }

        private void pictureBxMainScreen_Click(object sender, EventArgs e)
        {

        }
    }
}
