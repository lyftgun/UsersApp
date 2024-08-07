using ControlzEx.Standard;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public string NameItem;
        public string TechnicalСharacteristics;
        public string Description;
        public int Price;
        public int Quantity;
        public byte[] photo;
        public bool pricetest;
        public bool quantitytest;
        public int num;

        AppContext db;

        public AdminWindow()
        {
            InitializeComponent();

            db = new AppContext();
        }

        private void input()
        {
            NameItem = TextBox_NameItem.Text;
            TechnicalСharacteristics = TextBox_TechnicalCharacteristics.Text;
            Description = TextBox_Despription.Text;

            pricetest = Int32.TryParse(TextBox_Price.Text, out num);
            quantitytest = Int32.TryParse(TextBox_quantity.Text, out num);
        }


        private void check()
        {
            if (NameItem == "")
            {
                MessageBox.Show("Название товара должно быть заполнено");
                TextBox_NameItem.Background = Brushes.Orange;
            }

            if (pricetest)
            {
                Price = Convert.ToInt32(TextBox_Price.Text);
            }
            else
            {
                MessageBox.Show("Цена товара должно быть заполнено");
                TextBox_Price.Background = Brushes.Orange;
            }

            if (quantitytest)
            {
                Quantity = Convert.ToInt32(TextBox_quantity.Text);
            }
            else
            {
                MessageBox.Show("Колличество товара должно быть заполнено");
                TextBox_quantity.Background = Brushes.Orange;
            }
        }


        private void ItemReg(object sender, RoutedEventArgs e)
        {
            input();
            check();

            Item item = new Item(NameItem, TechnicalСharacteristics, Description, Quantity, Price, photo);

            db.Items.Add(item);
            db.SaveChanges();
            MessageBox.Show("Товар добавлен");
        }

        private void Button_UserPageWindows(object sender, RoutedEventArgs e)
        {
            UserPageWindow usergage = new UserPageWindow();
            usergage.Show();
            Hide();
            MessageBox.Show("Фотография добавлена");
        }

        private void PhotoReg(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                photo = File.ReadAllBytes(imagePath);
            }
        }

        private void Button_Bank(object sender, RoutedEventArgs e)
        {
            Bankcard bankcard = new Bankcard();
            bankcard.Show();
            Hide();
        }
    }
}
