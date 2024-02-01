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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(xx.Text);
                double y = double.Parse(yy.Text);
                string otv;
                if(y==0 && x <=0 &&x>=-23||x == -23 && y <= 0 && y >= -23 || y == x && x <= 0 && x >= -23)
                {
                    otv = "На границе";

                }
                else if(y <= 0 && y >=-23 && x >= -23 && x <= 0 && y >= x)
                {
                    otv = "Да";
                }
                else
                {
                    otv = "Нет";
                }
                ot.Text = $"{otv}";
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели не число или ничего не ввели");

            }
        }
    }
}
