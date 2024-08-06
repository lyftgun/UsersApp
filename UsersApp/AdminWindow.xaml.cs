using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ItemReg(object sender, RoutedEventArgs e)
        {

        }

        private void Button_UserPageWindows(object sender, RoutedEventArgs e)
        {
            UserPageWindow usergage = new UserPageWindow();
            usergage.Show();
            Hide();
        }

        private void PhotoReg(object sender, RoutedEventArgs e)
        {
            //byte[] imageData = File.ReadAllBytes(imagePath);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                // Ваш код для загрузки изображения...
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
