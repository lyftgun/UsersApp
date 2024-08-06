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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Aut_Click(object sender, RoutedEventArgs e)
        {
            string role = "admin";
            string login = TextBox_Login.Text.Trim();
            string password = PassBox_Pass.Password.Trim();


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
            else
            {
                TextBox_Login.Background = Brushes.Transparent;
                PassBox_Pass.Background = Brushes.Transparent;

                User autUser = null;
                using (AppContext db = new AppContext())
                {
                    autUser = db.Users.Where(q => q.Login == login && q.Password == password).FirstOrDefault();
                }

                if (autUser == null)
                {
                    MessageBox.Show("Данного акаунта не существует");
                }
                else
                {
                    User autRoleUser = null;
                    using (AppContext wr = new AppContext())
                    {
                        autRoleUser = wr.Users.Where(w =>w.Login == login && w.Role == role).FirstOrDefault();
                    }

                    if (autRoleUser == null)
                    {
                        MessageBox.Show("Здравствуйте " + login);
                        Personal_account per = new Personal_account();
                        per.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Здравствуйте админ " + login);
                        AdminWindow adm = new AdminWindow();
                        adm.Show();
                        Hide();
                    }
                }
            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow reg = new MainWindow();
            reg.Show();
            Hide();
        }
    }
}
