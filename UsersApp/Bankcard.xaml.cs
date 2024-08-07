using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для Bankcard.xaml
    /// </summary>
    public partial class Bankcard : Window
    {
        AppContext db;

        public Bankcard()
        {
            InitializeComponent();

            db = new AppContext();
        }

        public int num;
        public int Balance;
        public int cvv;
        public string BankCard;
        public bool BalanceTest;
        public bool cvvTest;

        private void input()
        { 
            BankCard = Textbox_Card.Text;
            BalanceTest = Int32.TryParse(Textbox_Price.Text, out num);
            cvvTest = Int32.TryParse(Textbox_cvv.Text, out num);
        }

        private void check() 
        {
            if (BalanceTest)
            {
                Balance = Convert.ToInt32(Textbox_Price.Text);
                Textbox_Price.Background = Brushes.Transparent;
            }
            else
            {
                MessageBox.Show("Баланс карты должен быть заполнен");
                Textbox_Price.Background = Brushes.Orange;
            }

            if (cvvTest)
            {
                cvv = Convert.ToInt32(Textbox_cvv.Text);
                Textbox_cvv.Background = Brushes.Transparent;
            }
            else
            {
                MessageBox.Show("cvv карты должен быть заполнен");
                Textbox_cvv.Background = Brushes.Orange;
            }

            if(19==BankCard.Length)
            {
                Textbox_Card.Background = Brushes.Transparent;
            }
            else
            {
                MessageBox.Show("Номер банковской карты должен быть заполнен корректно");
                Textbox_Card.Background = Brushes.Orange;
            }
        
        }





        private void ButtonReg(object sender, RoutedEventArgs e)
        {
            input();
            check();

            Bank bank = new Bank(BankCard, cvv, Balance);

            db.Banks.Add(bank);
            db.SaveChanges();
            MessageBox.Show("Карта зарегистрирована");
        }

        private void ButtonUpd(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            AdminWindow adm = new AdminWindow();
            adm.Show();
            Hide();
        }

        private void ButtonItem(object sender, RoutedEventArgs e)
        {
            Personal_account per = new Personal_account();
            per.Show();
            Hide();
        }
    }
}
