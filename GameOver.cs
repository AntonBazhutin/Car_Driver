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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }
        private void GameOver_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnYes_MouseMove(object sender, MouseEventArgs e)
        {
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.ForeColor = Color.White;
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.FlatStyle = FlatStyle.Popup;
            btnYes.ForeColor = Color.Gray;
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.ForeColor = Color.White;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gf = new GameForm();
            gf.ShowDialog();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.FlatStyle = FlatStyle.Popup;
            btnNo.ForeColor = Color.Gray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
