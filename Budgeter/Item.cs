using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.ComponentModel;

namespace Budgeter
{
    public class Item
    {

        public static Dictionary<string, Item> items = new Dictionary<string, Item>();

        private string name;
        public string Name
        {
            get => name;
            set { name = value;}
        }

        private int price;
        public int Price
        {
            get => price;
            set { price = value;}
        }

        public DateTime? dateOfPurchase;
        public DateTime? DateOfPurchase
        {
            get => dateOfPurchase;
            set { dateOfPurchase= value;}
        }

        public Item()
        { }

        public Item(string Name, string Price, DateTime? date)
        {
            name = Name;
            price = Convert.ToInt32(Price);
            dateOfPurchase = date;
        }

        public static void ItemsAdd()
        {
            items.Add("Hra na PC", new Item
            {
                Name = "Hra na PC",
                Price = 1500,
                DateOfPurchase = new DateTime?(DateTime.Now)
            }) ;

            items.Add("Cigarety", new Item
            {
                Name = "Cigarety",
                Price = 120,
                DateOfPurchase = new DateTime?(DateTime.Now)
            });

            items.Add("Kafe",new Item
            {
                Name = "Kafe",
                Price = 50,
                DateOfPurchase = new DateTime?(DateTime.Now)
            });
        }
    }
}
