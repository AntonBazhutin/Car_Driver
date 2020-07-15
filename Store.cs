using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDriver2
{
    public partial class Store : Form
    {
        string[] NamesOfCars = new string[] { "Blue Mustang", "Green Cabrio", "Yellow Lambo", "Red Porsche" };
        string[] CostOfCars = new string[] { "0", "150", "500", "750" };
        int index = 0;
        public Store()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
            this.Close();
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Gray;
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.White;
        }

        private void Store_Load(object sender, EventArgs e)
        {
            labelNameOfCar.Parent = pictureBox1;
            labelNameOfCar.BackColor = Color.Transparent;
            labelCostOfCar.Parent = pictureBox1;
            labelCostOfCar.BackColor = Color.Transparent;
            labelStore.Parent = pictureBox1;
            labelStore.BackColor = Color.Transparent;
            labelCOC.Text = "0";
            pbCars.Image = imageListCars.Images[0];
            labelCostOfCar.Text = '"' + CostOfCars[0] + '"';
            labelNameOfCar.Text = '"' + NamesOfCars[0] + '"';

        }

        private void btnBuy_MouseLeave(object sender, EventArgs e)
        {
            btnBuy.BackColor = Color.Gray;
        }

        private void btnBuy_MouseMove(object sender, MouseEventArgs e)
        {
            btnBuy.BackColor = Color.White;
        }
        private void btnGoRight_Click(object sender, EventArgs e)
        {
            if (index + 1 < imageListCars.Images.Count)
            {
                index++;
                pbCars.Image = imageListCars.Images[index];
                labelCostOfCar.Text = '"' + CostOfCars[index] + '"';
                labelNameOfCar.Text = '"' + NamesOfCars[index] + '"';
            }
        }

        private void btnGoLeft_Click(object sender, EventArgs e)
        {
            if (index + 1 >= imageListCars.Images.Count - index - 1)
            {
                index--;
                pbCars.Image = imageListCars.Images[index];
                labelCostOfCar.Text = '"' + CostOfCars[index] + '"';
                labelNameOfCar.Text = '"' + NamesOfCars[index] + '"';
            }
        }
    }
}
