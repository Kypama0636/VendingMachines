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

namespace VendingMachine
{
    /// <summary>
    /// Логика взаимодействия для Sis_Panel.xaml
    /// </summary>
    public partial class Sis_Panel : Window
    {
        public Sis_Panel(Window window)
        {
            InitializeComponent();
            var c = x.Drinks.ToList();
            LViewDrinks.ItemsSource = c;
            var coins1= x.VendingMachineCoins.Single(a=>a.VendingMachineId==1 && a.CoinsId==1);
            tb1.Text = coins1.Count.ToString();
            if (coins1.IsActive == 1)
            {
                cb1.IsChecked = true;
            }
            else {
                cb1.IsChecked = false;
            }
            var coins2 = x.VendingMachineCoins.Single(a => a.VendingMachineId == 1 && a.CoinsId == 2);
            tb2.Text = coins2.Count.ToString();
            if (coins2.IsActive == 1)
            {
                cb2.IsChecked = true;
            }
            else
            {
                cb2.IsChecked = false;
            }
            var coins3 = x.VendingMachineCoins.Single(a => a.VendingMachineId == 1 && a.CoinsId == 3);
            tb3.Text = coins3.Count.ToString();
            if (coins3.IsActive == 1)
            {
                cb3.IsChecked = true;
            }
            else
            {
                cb3.IsChecked = false;
            }
            var coins4 = x.VendingMachineCoins.Single(a => a.VendingMachineId == 1 && a.CoinsId == 4);
            tb4.Text = coins4.Count.ToString();
            if (coins4.IsActive == 1)
            {
                cb4.IsChecked = true;
            }
            else
            {
                cb4.IsChecked = false;
            }

        }
        VendingMachinesEntities x = new VendingMachinesEntities();
        private void enable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_money_Click(object sender, RoutedEventArgs e)
        {
            money.Visibility= Visibility.Visible;
            napitki.Visibility = Visibility.Hidden;
            otchet.Visibility = Visibility.Hidden;
        }

        private void b_napitki_Click(object sender, RoutedEventArgs e)
        {
            money.Visibility = Visibility.Hidden;
            napitki.Visibility = Visibility.Visible;
            otchet.Visibility = Visibility.Hidden;
        }

        private void b_otchet_Click(object sender, RoutedEventArgs e)
        {
            money.Visibility = Visibility.Hidden;
            napitki.Visibility = Visibility.Hidden;
            otchet.Visibility = Visibility.Visible;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            
            List<TextBox> CoinTxt = new List<TextBox>() { tb1, tb2, tb3, tb4 };
            List<CheckBox> CoinCh = new List<CheckBox>() { cb1, cb2,cb3, cb4 };
            List<string> CoinLbl = new List<string>() { "1", "2", "5", "10" };
            for (int i = 0; i < CoinCh.Count; i++)
            {
                var coindem = CoinLbl[i];
                var u = x.Coins.Single(a => a.Denomination.ToString() == coindem.ToString());
                var id = u.Id;

                var q = x.VendingMachineCoins.Single(d => d.CoinsId == id);
                q.Count = Convert.ToInt32(CoinTxt[i].Text);
                if (CoinCh[i].IsChecked == true)
                {
                    q.IsActive = 1;
                }
                else
                {
                    q.IsActive = 0;
                }
                x.SaveChanges();
            }

        }
    }
}
