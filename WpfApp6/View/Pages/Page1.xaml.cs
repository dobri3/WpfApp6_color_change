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

namespace WpfApp6.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            double a = 15;
            double b = 13;

            if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(a + b, 2))
                {
                MessageBox.Show("1 вариант");
            
            }
            if (Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(a + b, 2))
            {
                MessageBox.Show("2 вариант");

            }
            else
            {
                MessageBox.Show("Равны");
            }
        }
    }
}
