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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x1 = double.Parse(xx1.Text);
                double y1 = double.Parse(yy1.Text);
                double x2 = double.Parse(xx2.Text);
                double y2 = double.Parse(yy2.Text);
                double otv = Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));
                ot.Text = $"Ответ: расстояние {otv}";
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели не число или ничего не ввели");
                
            }
            
        }
    }
}
