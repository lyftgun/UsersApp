using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data.SQLite;
using ControlzEx.Standard;

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для Personal_account.xaml
    /// </summary>
    public partial class Personal_account : Window
    {
        AppContext bd;
        public Personal_account()
        {
            InitializeComponent();

            bd = new AppContext();
        }

        private void Button_Aut_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
