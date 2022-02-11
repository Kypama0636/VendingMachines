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
    /// Логика взаимодействия для Security.xaml
    /// </summary>
    public partial class Security : Window
    {
        public Security()
        {
            InitializeComponent();
        }
        VendingMachinesEntities x = new VendingMachinesEntities();
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (x.VendingMachines.Single(a => a.SecretCode == tb1.Text && a.Id==1) != null)
                {
                    Sis_Panel sis_Panel = new Sis_Panel(this);
                    sis_Panel.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Секретный код неправильный!");
            }
           
        }
    }
}
