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

namespace HelloGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Input = int.Parse(txtIncome.Text);
            int Pay = int.Parse(txtExpend.Text);
            int Wish = int.Parse(txtWishlist.Text);
            int Money = Wish/ (Input-Pay);         
            txtMoney.Text = Money.ToString();
        }
        private void txtIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            long a;
            if (!long.TryParse(txtIncome.Text, out a))txtIncome.Clear();     
            }
        private void txtExpend_TextChanged(object sender, TextChangedEventArgs e)
        {
            long a;
            if (!long.TryParse(txtExpend.Text, out a)) txtExpend.Clear();}
        private void txtWishlist_TextChanged(object sender, TextChangedEventArgs e)
        {
            long a;
            if (!long.TryParse(txtWishlist.Text, out a)) txtWishlist.Clear();
        }
    }
 }

