using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();

            AppContext bd = new AppContext();
            List<User> users = bd.Users.ToList();

            listOfUsers.ItemsSource = users;
        }

        private void Button_account_Click(object sender, RoutedEventArgs e)
        {
            Personal_account personal_account = new Personal_account();
            personal_account.Show();
            Hide();
        }

        private void Button_Adm(object sender, RoutedEventArgs e)
        {
            AdminWindow adm = new AdminWindow();
            adm.Show();
            Hide();
        }
    }
}
