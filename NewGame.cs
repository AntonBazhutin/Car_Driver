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
            if (File.Exists("purchasedItems.dat"))
                File.Delete("purchasedItems.dat");
            if (File.Exists("score.dat"))
                File.Delete("score.dat");
            if (File.Exists("score_2.dat"))
                File.Delete("score_2.dat");
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
    }
}
