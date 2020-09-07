using CarDriver2.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarDriver2
{
    public partial class Store : Form
    {
        List<storeAbstractCar> listOfCars = new List<storeAbstractCar>();
        string[] NamesOfCars = new string[] { "Blue Mustang", "Green Cabrio", "Yellow Lambo", "Red Porsche" };

        int[] CostOfCars = new int[] { 0, 150, 500, 750 };
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
            if (!File.Exists("purchasedItems.dat"))
            {
                File.Create("purchasedItems.dat").Close();

                Settings.Default.Blue_Mustang = true;
                Settings.Default.Green_Cabrio = false;
                Settings.Default.Yellow_Lambo = false;
                Settings.Default.Red_Porsche = false;

                FileManager.Save_Items(new purchasedItems(Settings.Default.Blue_Mustang, Settings.Default.Green_Cabrio, Settings.Default.Yellow_Lambo, Settings.Default.Red_Porsche));
            }

            for (int i = 0; i < NamesOfCars.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        listOfCars.Add(new storeIsBoughtCar("Blue Mustang", 0, true));
                        break;
                    case 1:
                        if (FileManager.Load_Items().Green == true)
                            listOfCars.Add(new storeIsBoughtCar("Green Cabrio", 150, true));
                        else
                            listOfCars.Add(new storeCar("Green Cabrio", 150));
                        break;
                    case 2:
                        if (FileManager.Load_Items().Yellow == true)
                            listOfCars.Add(new storeIsBoughtCar("Yellow Lambo", 500, true));
                        else
                            listOfCars.Add(new storeCar("Yellow Lambo", 500));
                        break;
                    case 3:
                        if (FileManager.Load_Items().Red == true)
                            listOfCars.Add(new storeIsBoughtCar("Red Porsche", 750, true));
                        else
                            listOfCars.Add(new storeCar("Red Porsche", 750));
                        break;
                    default: break;
                }
            }

            if (File.Exists("score_2.dat") && File.Exists("score.dat"))
                txtBxMyCoins.Text = Settings.Default.Coins.ToString();
            else
                txtBxMyCoins.Text = "0";

            labelStore.Parent = pictureBox1;
            labelStore.BackColor = Color.Transparent;

            pbCars.Image = imageListCars.Images[0];
            txtBxName.Text = NamesOfCars[0];

            if (listOfCars[index] is storeIsBoughtCar)
                txtBxCost.Text = "Purchased";
            else
                txtBxCost.Text = listOfCars[index].Cost.ToString();
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
                txtBxName.Text = NamesOfCars[index];
                if (listOfCars[index] is storeIsBoughtCar)
                    txtBxCost.Text = "Purchased";
                else
                    txtBxCost.Text = listOfCars[index].Cost.ToString();
            }
        }

        private void btnGoLeft_Click(object sender, EventArgs e)
        {
            if (index + 1 >= imageListCars.Images.Count - index - 1)
            {
                index--;
                pbCars.Image = imageListCars.Images[index];
                txtBxName.Text = NamesOfCars[index];
                if (listOfCars[index] is storeIsBoughtCar)
                    txtBxCost.Text = "Purchased";
                else
                    txtBxCost.Text = listOfCars[index].Cost.ToString();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (listOfCars[index] is storeCar && txtBxCost.Text != "Purchased")
            {
                if (int.Parse(txtBxMyCoins.Text) >= int.Parse(txtBxCost.Text))
                {
                    storeIsBoughtCar str = new storeIsBoughtCar(listOfCars[index].Name, listOfCars[index].Cost, true);
                    listOfCars[index] = str;
                    switch (index)
                    {
                        case 0:
                            Settings.Default.Blue_Mustang = true;
                            break;
                        case 1:
                            Settings.Default.Green_Cabrio = true;
                            break;
                        case 2:
                            Settings.Default.Yellow_Lambo = true;
                            break;
                        case 3:
                            Settings.Default.Red_Porsche = true;
                            break;
                        default: break;
                    }

                    Settings.Default.Coins -= int.Parse(txtBxCost.Text);
                    txtBxMyCoins.Text = Settings.Default.Coins.ToString();
                    FileManager.Save_Items(new purchasedItems(Settings.Default.Blue_Mustang, Settings.Default.Green_Cabrio, Settings.Default.Yellow_Lambo, Settings.Default.Red_Porsche));
                    FileManager.Save_TotalScore(new TotalGameInfo(Settings.Default.Record, Settings.Default.Score, Settings.Default.Coins, Settings.Default.Speed, Settings.Default.Min, Settings.Default.Sec
                        ));

                    listOfCars.Clear();

                    for (int i = 0; i < NamesOfCars.Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                listOfCars.Add(new storeIsBoughtCar("Blue Mustang", 0, true));
                                break;
                            case 1:
                                if (FileManager.Load_Items().Green == true)
                                    listOfCars.Add(new storeIsBoughtCar("Green Cabrio", 150, true));
                                else
                                    listOfCars.Add(new storeCar("Green Cabrio", 150));
                                break;
                            case 2:
                                if (FileManager.Load_Items().Yellow == true)
                                    listOfCars.Add(new storeIsBoughtCar("Yellow Lambo", 500, true));
                                else
                                    listOfCars.Add(new storeCar("Yellow Lambo", 500));
                                break;
                            case 3:
                                if (FileManager.Load_Items().Red == true)
                                    listOfCars.Add(new storeIsBoughtCar("Red Porsche", 750, true));
                                else
                                    listOfCars.Add(new storeCar("Red Porsche", 750));
                                break;
                            default: break;
                        }
                    }

                    MessageBox.Show("Selected item successfully purchased");
                }
                else
                    MessageBox.Show("Not enough funds to buy this item");
            }
            else
                MessageBox.Show("This item is already purchased");
        }

        private void btnGoRight_MouseLeave(object sender, EventArgs e)
        {
            btnGoRight.BackColor = Color.Gray;
        }

        private void btnGoRight_MouseMove(object sender, MouseEventArgs e)
        {
            btnGoRight.BackColor = Color.White;
        }

        private void btnGoLeft_MouseLeave(object sender, EventArgs e)
        {
            btnGoLeft.BackColor = Color.Gray;
        }

        private void btnGoLeft_MouseMove(object sender, MouseEventArgs e)
        {
            btnGoLeft.BackColor = Color.White;
        }

        private void txtBxCost_TextChanged(object sender, EventArgs e)
        {
            if (listOfCars[index] is storeIsBoughtCar)
                txtBxCost.Text = "Purchased";
            else
                txtBxCost.Text = listOfCars[index].Cost.ToString();
        }
    }
}
