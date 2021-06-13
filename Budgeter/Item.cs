using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeter
{
    public class Item
    {
        public static List<Item> items = new List<Item>();

        public string name;
        public int price;
        public DateTime? dateOfPurchase;

        public Item()
        { }

        public Item(string Name, string Price, DateTime? date)
        {
            name = Name;
            price = Convert.ToInt32(Price);
            dateOfPurchase = date;
        }
    }
}
