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
using static System.Math;

namespace PEtrov_ekzamen
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(aa.Text);
                double x = double.Parse(xx.Text);
                double b = double.Parse(bb.Text);
                double otv;
                if (x > PI)
                {
                    otv = 1 - Exp(-a * x) * Sin(a * x + b);
                }
                else if(-PI <= x && x <= PI)
                {
                    otv = 1 - Exp(-a * x) * (a * x + b);
                }
                else
                {
                    otv = 1 - (Exp(-a * x) + Exp(-b * x));
                }
                ot.Text = $"Ответ:  {otv}";
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели не число или ничего не ввели");

            }
        }
    }
}
