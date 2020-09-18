using CarDriver2.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarDriver2
{
    public partial class Garage : Form
    {
        List<storeAbstractCar> listOfCars = new List<storeAbstractCar>();
        string[] NamesOfCars = new string[] { "Blue Mustang", "Green Cabrio", "Yellow Lambo", "Red Porsche" };

        int index = 0;
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

            for (int i = 0; i < NamesOfCars.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        listOfCars.Add(new storeIsBoughtCar(NamesOfCars[i], 0, true));
                        break;
                    case 1:
                        if (FileManager.Load_Items().Green == true)
                            listOfCars.Add(new storeIsBoughtCar(NamesOfCars[i], 150, true));
                        else
                            listOfCars.Add(new storeCar(NamesOfCars[i], 150));
                        break;
                    case 2:
                        if (FileManager.Load_Items().Yellow == true)
                            listOfCars.Add(new storeIsBoughtCar(NamesOfCars[i], 500, true));
                        else
                            listOfCars.Add(new storeCar(NamesOfCars[i], 500));
                        break;
                    case 3:
                        if (FileManager.Load_Items().Red == true)
                            listOfCars.Add(new storeIsBoughtCar(NamesOfCars[i], 750, true));
                        else
                            listOfCars.Add(new storeCar(NamesOfCars[i], 750));
                        break;
                    default: break;
                }
            }

            pbCars.Image = imageListCars.Images[index];
            txtBxName.Text = NamesOfCars[index];
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (listOfCars[index] is storeIsBoughtCar)
            {
                if (FileManager.Load_chosenCar().Cost == listOfCars[index].Cost && FileManager.Load_chosenCar().Name == listOfCars[index].Name)
                    MessageBox.Show("This item is already equiped");
                else
                {
                    FileManager.Save_chosenCar(new storeChosenCar(listOfCars[index].Name, listOfCars[index].Cost, true));
                    MessageBox.Show("Equiped");
                }
            }
            else
            {
                MessageBox.Show("To equip this car you need to purchase it");
            }
        }

        private void btnGoRight_Click(object sender, EventArgs e)
        {
            if (index + 1 < imageListCars.Images.Count)
            {
                index++;
                txtBxName.Text = NamesOfCars[index];
                if (listOfCars[index] is storeIsBoughtCar)
                    pbCars.Image = imageListCars.Images[index];
                if (listOfCars[index] is storeCar)
                    pbCars.Image = imageListNonBought.Images[index];
            }
        }

        private void btnGoLeft_Click(object sender, EventArgs e)
        {
            if (index + 1 >= imageListCars.Images.Count - index - 1)
            {
                index--;
                txtBxName.Text = NamesOfCars[index];
                if (listOfCars[index] is storeIsBoughtCar)
                    pbCars.Image = imageListCars.Images[index];
                if (listOfCars[index] is storeCar)
                    pbCars.Image = imageListNonBought.Images[index];
            }
        }

        private void btnGoRight_MouseLeave(object sender, EventArgs e)
        {
            btnGoRight.BackColor = Color.Gray;
        }

        private void btnGoRight_MouseMove(object sender, MouseEventArgs e)
        {
            btnGoRight.BackColor = Color.White;
        }

        private void btnGoLeft_MouseMove(object sender, MouseEventArgs e)
        {
            btnGoLeft.BackColor = Color.White;
        }

        private void btnGoLeft_MouseLeave(object sender, EventArgs e)
        {
            btnGoLeft.BackColor = Color.Gray;
        }

        private void btnEquip_MouseMove(object sender, MouseEventArgs e)
        {
            btnEquip.BackColor = Color.White;
        }

        private void btnEquip_MouseLeave(object sender, EventArgs e)
        {
            btnEquip.BackColor = Color.Gray;
        }
    }
}
