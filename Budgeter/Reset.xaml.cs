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
using System.Windows.Shapes;

namespace Budgeter
{
    /// <summary>
    /// Interakční logika pro Reset.xaml
    /// </summary>
    public partial class Reset : Window
    {
        public Reset()
        {
            InitializeComponent();
            amount.DataContext = Item.MoneyTotal;
        }

        private void done_Click(object sender, RoutedEventArgs e)
        {
            Item.MoneyTotal = Convert.ToInt32(amount.Text);
            Item.MoneyRemaining = Item.MoneyTotal;
        }
    }
}
