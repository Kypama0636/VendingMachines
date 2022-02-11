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
using System.Windows.Threading;

namespace VendingMachine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] coins_add = new int[4];
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                var c = x.Drinks.ToList();
                lviewdrinks.ItemsSource = c;
            }
            catch { 
                

            }
            
            

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
        }
        public void UpdateData(object sender, object e)
        {
            VendingMachinesEntities database = new VendingMachinesEntities();
            lviewdrinks.ItemsSource = database.Drinks.ToList();
            List<Button> CoinButtons = new List<Button>() { m1, m2, m5, m10 };
            for (int i = 0; i < CoinButtons.Count; i++)
            {
                var coindem = CoinButtons[i].Content;
                var u = database.Coins.Single(a => a.Denomination.ToString() == coindem.ToString());
                var id = u.Id;

                var q = database.VendingMachineCoins.Single(d => d.CoinsId == id);
                var active = q.IsActive;
                if (active == 0)
                {
                    CoinButtons[i].IsEnabled = false;
                }
                else
                {
                    CoinButtons[i].IsEnabled = true;
                }
            }
        }
        VendingMachinesEntities x = new VendingMachinesEntities();
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            //Сдача
            int a = Convert.ToInt32(tb1.Text.Replace(" руб.","")) ;
           
            var mon1 = x.VendingMachineCoins.Single(m1=>m1.CoinsId==1);
            var mon2 = x.VendingMachineCoins.Single(m1 => m1.CoinsId == 2);
            var mon5 = x.VendingMachineCoins.Single(m1 => m1.CoinsId == 3);
            var mon10 = x.VendingMachineCoins.Single(m1 => m1.CoinsId == 4);

            int f1 = mon1.Count;
            int f2 = mon2.Count;
            int f5 = mon5.Count;
            int f10 = mon10.Count;

            int[] coins = new int[4];
            coins[0] = 0;
            coins[1] = 0;
            coins[2] = 0;
            coins[3] = 0;
            for (int i = a; i >= 0;)
            {
                if (i >= 10 && f10 > 0)
                {
                    i -= 10;
                    coins[3]++;
                    f10--;
                }
                else
                {
                    if (i >= 5 && f5 > 0)
                    {
                        i -= 5;
                        coins[2]++;
                        f5--;
                    }
                    else
                    {
                        if (i >= 2 && f2 > 0)
                        {
                            i -= 2;
                            coins[1]++;
                            f2--;
                        }
                        else
                        {
                            if (i >= 1 && f1 > 0)
                            {
                                i -= 1;
                                coins[0]++;
                                f1--;
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    MessageBox.Show("Заберите сдачу!");
                                    a = i;
                                    i--;
                                }
                                else
                                {
                                    MessageBox.Show("В аппарате недостаточно средств!");
                                    a = i;
                                    i--;
                                }
                            }
                        }
                    }
                }
            }
            tb1.Text = a.ToString() + " руб.";
            int[] coins1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                coins1[i] = coins[i] - coins_add[i];
            }
            for (int i = 0; i < 4; i++)
            {
                var nowCoin = x.VendingMachineCoins.Single(id => id.CoinsId == (i + 1));
                nowCoin.Count = nowCoin.Count - coins1[i];
                x.SaveChanges();
            }
            for (int i = 0; i < 4; i++)
            {
                if (coins[i] < 0)
                {
                    coins[i] = 0;
                }
            }
           
            MessageBox.Show("Один рубль = " + coins[0] + "\n Два рубля = " + coins[1] + "\n Пять рублей = " + coins[2] + "\n Десять рублей = " + coins[3]);



        }

        private void m1_Click(object sender, RoutedEventArgs e)
        {
            int tb = Convert.ToInt32(tb1.Text.Replace(" руб.", ""));
            tb1.Text = Convert.ToString(tb + 1) + " руб.";
            coins_add[0]++;
        }

        private void m2_Click(object sender, RoutedEventArgs e)
        {
            int tb = Convert.ToInt32(tb1.Text.Replace(" руб.", ""));
            tb1.Text = Convert.ToString(tb + 2) + " руб.";
            coins_add[1]++;
        }

        private void m5_Click(object sender, RoutedEventArgs e)
        {
            int tb = Convert.ToInt32(tb1.Text.Replace(" руб.", ""));
            tb1.Text = Convert.ToString(tb + 5) + " руб.";
            coins_add[2]++;
        }

        private void m10_Click(object sender, RoutedEventArgs e)
        {
            int tb = Convert.ToInt32(tb1.Text.Replace(" руб.", ""));
            tb1.Text = Convert.ToString(tb + 10) + " руб.";
            coins_add[3]++;

        }

        private void butmenu_Click(object sender, RoutedEventArgs e)
        {

            Security security = new Security();
            security.Show();

        }

        private void lViewDrinks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int actuallyCoin = Convert.ToInt32(tb1.Text.Replace(" руб.",""));

          
                if (lviewdrinks.SelectedItem != null)
                {
                    if (actuallyCoin >= Convert.ToInt32((lviewdrinks.SelectedItem as Drinks).Cost))
                    {
                        actuallyCoin -= Convert.ToInt32((lviewdrinks.SelectedItem as Drinks).Cost);

                        tb1.Text = actuallyCoin.ToString() + " руб.";
                    
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно денег на счету!");
                    }
                }
           
            x.SaveChanges();
            lviewdrinks.SelectedItem = null;
        }
    }
}
