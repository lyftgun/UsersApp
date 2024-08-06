using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    internal class Basket
    {
        [Key]
        public int IDBasket { get; set; }

        private int iditem, iduser;

        public int IDItem
        {
            get { return iditem; }
            set { iditem = value; }
        }

        public int IDUser
        {
            get { return iduser; }
            set { iduser = value; }
        }

        public Basket(){}

        public Basket(int iDItem, int iDUser)
        {
            this.iditem = iDItem;
            this.iduser = iDUser;
        }
    }
}
