using CarDriver2.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace CarDriver2
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string[] paths = new string[] { "purchasedItems.dat", "score.dat", "score_2.dat", "chosenCar.dat" };

            foreach (var file in paths)
            {
                File.WriteAllText($"{file}", string.Empty);
            }

            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.FlatStyle = FlatStyle.Popup;
            btnYes.ForeColor = Color.Gray;
        }

        private void btnYes_MouseMove(object sender, MouseEventArgs e)
        {
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.ForeColor = Color.White;
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.FlatStyle = FlatStyle.Popup;
            btnNo.ForeColor = Color.Gray;
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.ForeColor = Color.White;
        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }
    }
}
