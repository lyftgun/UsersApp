using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    internal class User
    {
        [Key]
        public int IDUser { get; set; }

        private string login, password,role;

        public string Login { 
            get { return login; } 
            set { login = value; }
        }

        public string Password { 
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public User() { }

        public User(string Login, string Password,string Role)
        {
            this.login = Login;
            this.password = Password;
            this.role = Role;
        }

        public override string ToString()
        {
            return "Пользователь: " + login + " Роль: " + role;
        }
    }
}
