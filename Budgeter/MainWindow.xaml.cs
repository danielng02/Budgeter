using System;
using System.Collections.Generic;
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

namespace Budgeter
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Item.ItemsAdd();
            listbox.DataContext = Item.items;
            Item.MoneyTotal = 5000;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Item.items.Add(new Item(nameText.Text, priceText.Text, calendar.SelectedDate));

            Item.MoneyRemaining -= Convert.ToInt32(priceText.Text);

            if (Item.MoneyRemaining <= 0)
                money.Foreground = Brushes.Red;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item k = (Item)((sender as ListView).SelectedItem);
            DataContext = k;
        }

        private void reset_Click_1(object sender, RoutedEventArgs e)
        {
            Reset re = new Reset();
            re.ShowDialog();
        }
    }
}
