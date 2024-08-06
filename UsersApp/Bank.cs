using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace UsersApp
{
    internal class Bank
    {
        [Key]
        public int IDBank { get; set; }

        private string bankcard, cvv;

        private int balance;

        public string Bankcard
        {
            get { return bankcard; }
            set { bankcard = value; }
        }

        public string Cvv 
        { 
            get { return cvv; }
            set { cvv = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Bank() { }

        public Bank(string Bankcard, string Cvv, int Balance)
        {
            this.bankcard = Bankcard;
            this.cvv = Cvv;
            this.balance = Balance;
        }
    }
}
