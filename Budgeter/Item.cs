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
    public class Item : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public static ObservableCollection<Item> items { get; set; } = new ObservableCollection<Item>();

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private int price;
        public int Price
        {
            get => price;
            set { price = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price")); }
        }

        private DateTime? dateOfPurchase;
        public DateTime? DateOfPurchase
        {
            get => dateOfPurchase;
            set { dateOfPurchase= value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date")); }
        }

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
