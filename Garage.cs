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

namespace CarDriver2
{
    public partial class Garage : Form
    {
        public Garage()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
            this.Close();
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Gray;
        }

        private void btnPlay_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.White;
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            if (File.Exists("items.dat"))
            { 

            }
        }
    }
}
