using ControlzEx.Standard;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace UsersApp
{
    internal class Item
    {
        [Key]
        public int IDItems { get; set; }

        private string nameitem, technicalcharacteristics, description;
        private int quantity, price;
        private byte[] photo;

        public string NameItem
        {
            get { return nameitem; }
            set { nameitem = value; }
        }

        public string TechnicalСharacteristics
        {
            get { return technicalcharacteristics; }
            set { technicalcharacteristics = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity 
        { 
            get { return quantity; } 
            set { quantity = value; } 
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public Item() { }

        public Item(string NameItem, string TechnicalСharacteristics, string Description, int Quantity, int Price, byte[] Photo )
        {
            this.technicalcharacteristics = TechnicalСharacteristics; 
            this.description = Description; 
            this.quantity = Quantity; 
            this.nameitem = NameItem;
            this.photo = Photo;
            this.price = Price;
        }

        public override string ToString()
        {
            return "Фотография: " + photo + " название: " + nameitem + " Технические характеристики: " + technicalcharacteristics + " Описание: " + description + " Количество: " + quantity + " Стоимость: " + price;
        }
    }
}
