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

namespace zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    switch (fff.SelectedIndex)
                    {
                        case 0:
                            double x = Convert.ToDouble(A.Text);
                            double y = Convert.ToDouble(B.Text);
                            l.Content = x + y;
                            dop.Content = "Можно подсчитать";
                            break;

                        case 1:
                            x = Convert.ToDouble(A.Text);
                            y = Convert.ToDouble(B.Text);
                            l.Content = x - y;
                            dop.Content = "Можно подсчитать";
                            break;

                        case 2:
                            x = Convert.ToDouble(A.Text);
                            y = Convert.ToDouble(B.Text);
                            if (y == 0)
                            {
                                dop.Content = "На ноль делить нельзя";
                                dop.Foreground = Brushes.Red;
                            }


                            else
                            {
                                l.Content = x / y;
                                dop.Content = "Можно подсчитать";
                            }
                            break;

                        case 3:
                            x = Convert.ToDouble(A.Text);
                            y = Convert.ToDouble(B.Text);
                            l.Content = x * y;
                            dop.Content = "Можно подсчитать";
                            break;

                        case 4:
                            x = Convert.ToDouble(A.Text);
                            l.Content = Math.Round(Math.Sin(x));


                            break;

                        case 5:
                            x = Convert.ToDouble(A.Text);
                            l.Content = Math.Round(Math.Cos(x));

                            break;

                        case 6:
                            x = Convert.ToDouble(A.Text);
                            l.Content = Math.Round(Math.Tan(x));

                            break;

                        case 7:
                            x = Convert.ToDouble(A.Text);
                            l.Content = Math.Round(1 / Math.Tan(x));

                            break;
                    }
                }

                catch
                {
                    l.Content = "Error";
                }

            }
        }
    }
}
