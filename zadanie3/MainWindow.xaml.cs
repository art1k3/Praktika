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

namespace zadanie3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.choice.Items.Add("+");
            this.choice.Items.Add("-");
            this.choice.Items.Add("/");
            this.choice.Items.Add("*");
        }
        private void decision_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (choice.SelectedIndex)
                {
                    case 0:
                        double operant1 = Convert.ToDouble(number1.Text);
                        double operant2 = Convert.ToDouble(number2.Text);
                        answer.Content = operant1 + operant2;

                        break;

                    case 1:
                        operant1 = Convert.ToDouble(number1.Text);
                        operant2 = Convert.ToDouble(number2.Text);
                        answer.Content = operant1 - operant2;
                        dop.Content = "";
                        break;

                    case 2:
                        operant1 = Convert.ToDouble(number1.Text);
                        operant2 = Convert.ToDouble(number2.Text);
                        if (operant2 == 0)
                        {
                            dop.Content = "На ноль делить нельзя";
                            dop.Foreground = Brushes.Green;
                        }


                        else
                        {
                            answer.Content = operant1 / operant2;
                            dop.Content = "";
                        }
                        break;

                    case 3:
                        operant1 = Convert.ToDouble(number1.Text);
                        operant2 = Convert.ToDouble(number2.Text);
                        answer.Content = operant1 * operant2;
                        dop.Content = "";
                        break;

                    case 4:
                        operant1 = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Sin(operant1));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 5:
                        operant1 = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Cos(operant1));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 6:
                        operant1 = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(Math.Tan(operant1));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;

                    case 7:
                        operant1 = Convert.ToDouble(number1.Text);
                        answer.Content = Math.Round(1 / Math.Tan(operant1));
                        dop.Content = "Число для подсчета вводиться в первое поле";
                        dop.Foreground = Brushes.Black;
                        break;
                }
            }

            catch
            {
                answer.Content = "Введите число для подсчета в первое полe";
            }
        }
        // Задание 4
        private void check_Click(object sender, RoutedEventArgs e)
        {
            string pass = "543212345";
            if (pass == password.Text)
            {
                answer1.Content = "Пароль правильный KK";
            }
            else
            {
                answer1.Content = "ОЙ, ты ввел(а) неправильный пароль, давай заново.";
                answer1.Background = Brushes.Red;
            }
        }
        // Задание 3
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(a1.Text);
            if (number < 15)
                c1.Content = "[0-14]";
            else if (number < 36)
                c1.Content = "[15-35]";
            else if (number < 51)
                c1.Content = "[36-50]";
            else if (number < 100)
                c1.Content = "[51-100]";
        }
        // Задание 1
        private void trunslate_Click(object sender, RoutedEventArgs e)
        {
            {
                string sultry = "знойно";
                string stuffi = "духота";
                string couldy = "пасмурно";
                string foggy = "туманно";
                string cold = "холодно";
                string hot = "жарко";
                string wind = "ветренно";
                string hurri = "ураган";
                string rain = "дождь";
                string sun = "солнечно";
                if (sun == tb1.Text)
                {
                    perevod.Content = "sunny";
                }

                else if (rain == tb1.Text)
                {
                    perevod.Content = "rain";
                }

                else if (hurri == tb1.Text)
                {
                    perevod.Content = "hurricane";
                }

                else if (wind == tb1.Text)
                {
                    perevod.Content = "windy";
                }

                else if (hot == tb1.Text)
                {
                    perevod.Content = "hot";
                }

                else if (cold == tb1.Text)
                {
                    perevod.Content = "cold";
                }

                else if (foggy == tb1.Text)
                {
                    perevod.Content = "foggy";
                }

                else if (sultry == tb1.Text)
                {
                    perevod.Content = "sultry";
                }

                else if (stuffi == tb1.Text)
                {
                    perevod.Content = "stuffiness";
                }

                else if (couldy == tb1.Text)
                {
                    perevod.Content = "couldy";
                }
                else
                {
                    perevod.Content = "Введите другое слово!";
                }
            }
        }
    }
}