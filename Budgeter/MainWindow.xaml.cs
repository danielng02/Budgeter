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
using System.Text.RegularExpressions;

namespace Budgeter
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		public MainWindow()
        {
            InitializeComponent();
            listbox.DataContext = Item.items;
			ErrorLabelName.DataContext = this;
			ErrorLabelPrice.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Item.items.Add(new Item(nameText.Text, priceText.Text, calendar.SelectedDate));
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item k = (Item)((sender as ListView).SelectedItem);
            DataContext = k;
        }

        private void reset_Click_1(object sender, RoutedEventArgs e)
        {
			Item.items.Clear();
        }
		private bool CheckNameOK()
		{
			if(nameText.Text.Length > 0)
			{
				NameErrorVisible = Visibility.Hidden;
				return true;
			}
			else
			{
				NameErrorVisible = Visibility.Visible;
				return false;
			}
		}

		private Visibility _NameErrorVisible;
		public Visibility NameErrorVisible
		{
			get
			{
				return _NameErrorVisible;
			}

			set
			{
				_NameErrorVisible = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs("NameErrorVisible"));
			}
		}

		private string _NameError = "Name is mandatory";
		public string NameError
		{
			get
			{
				return _NameError;
			}
		}

		bool IsAllDigits(string s) => s.All(char.IsDigit);

		private bool CheckPriceOK()
		{
			if (priceText.Text.Length > 0 && IsAllDigits(priceText.Text))
			{
				PriceErrorVisible = Visibility.Hidden;
				return true;
			}
			else
            {
				PriceErrorVisible = Visibility.Visible;
				return false;
			}
		}

		private Visibility _PriceErrorVisible;
		public Visibility PriceErrorVisible
		{
			get
			{
				return _PriceErrorVisible;
			}

			set
			{
				_PriceErrorVisible = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs("PriceErrorVisible"));
			}
		}

		private string _PriceError = "You need to enter a number";
		public string PriceError
		{
			get
			{
				return _PriceError;
			}
		}

		private void nameText_TextChanged(object sender, TextChangedEventArgs e)
        {
			CheckNameOK();
        }

        private void priceText_TextChanged(object sender, TextChangedEventArgs e)
        {
			CheckPriceOK();
        }
    }
}
