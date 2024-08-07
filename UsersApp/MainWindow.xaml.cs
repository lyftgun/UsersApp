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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AppContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext();
        }
        private void Clear()
        {
            TextBox_Login.Background = Brushes.Transparent;
            PassBox_Pass.Background = Brushes.Transparent;
            PassBox_Pass2.Background = Brushes.Transparent;
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string role = "admin";
            string login = TextBox_Login.Text.Trim();
            string password = PassBox_Pass.Password.Trim();
            string password2 = PassBox_Pass2.Password.Trim();

            if (login.Length < 5)
            {
                MessageBox.Show("Логин должен быть больше 5 символов");
                TextBox_Login.Background = Brushes.Orange;
            }
            else if (password.Length < 5)
            {
                MessageBox.Show("Пароль должен быть больше 5 символов");
                PassBox_Pass.Background = Brushes.Orange;

                TextBox_Login.Background = Brushes.Transparent;
            }
            else if (password != password2)
            {
                MessageBox.Show("Пароли не совпадают");
                PassBox_Pass2.Background = Brushes.Orange;

                PassBox_Pass.Background = Brushes.Transparent;
            }
            else
            {
                Clear();
                MessageBox.Show("Вы зарегестрированы");
                User user = new User(login,password,role);

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        private void Button_authorization_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Hide();
        }
    }
}