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

namespace zadanie5
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
        public double Add()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            return x + y;
        }

        public double Sub()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            return x - y;
        }

        public double Mul()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            return x * y;
        }

        public string Div()
        {
            double x = Convert.ToDouble(n1.Text);
            double y = Convert.ToDouble(n2.Text);
            if (y != 0)
                return $"{x / y}";
            else
                return "На ноль делить нельзя";
        }

        private void z1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Method = Convert.ToString(no.Text);
                switch (Method)
                {
                    case "Div":
                        s.Content = Div();
                        break;
                    case "Sub":
                        s.Content = Sub();
                        break;
                    case "Mul":
                        s.Content = Mul();
                        break;
                    case "Add":
                        s.Content = Add();
                        break;
                }
            }
            catch
            {
                s.Content = "Error";
            }
        }

        private void z2_Click(object sender, RoutedEventArgs e)
        {
            double Money = Convert.ToDouble(m.Text);
            double Conversion = Convert.ToDouble(m1.Text);
            a.Content = Money * Conversion;
        }

        private void z3_Click(object sender, RoutedEventArgs e)
        {
            if (kol.Text == "")
            {
                MessageBox.Show("Укажите число для анализа", "Анализ числа", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            int number = int.Parse(kol.Text);
            NumberInfo(number);
        }

        private void NumberInfo(int number)
        {
            // Является ли введенное число положительным или отрицательным
            string negType;
            if (number >= 0)
                negType = "Положительное";
            else
                negType = "Отрицательное";

            // Является ли число простым
            string isPrime = "Является ли простым: ";
            if (IsPrime(number))
                isPrime = isPrime + "да";
            else
                isPrime = isPrime + "нет";

            // Делится ли на 2, 5, 3, 6, 9 без остатка
            string del2 = "Делится на 2: ";
            string del5 = "Делится на 5: ";
            string del3 = "Делится на 3: ";
            string del6 = "Делится на 6: ";
            string del9 = "Делится на 9: ";

            if (number % 2 == 0)
                del2 = del2 + "да";
            else
                del2 = del2 + "нет";

            if (number % 5 == 0)
                del5 = del5 + "да";
            else
                del5 = del5 + "нет";

            if (number % 3 == 0)
                del3 = del3 + "да";
            else
                del3 = del3 + "нет";

            if (number % 6 == 0)
                del6 = del6 + "да";
            else
                del6 = del6 + "нет";

            if (number % 9 == 0)
                del9 = del9 + "да";
            else
                del9 = del9 + "нет";

            lol.Text = negType + "\n" + isPrime + "\n" + del2 + "\n" + del5 + "\n" + del3 + "\n" + del6 + "\n" + del9;
        }
        // Является ли число простым
        private bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private double creditSum = 0; // Сумма кредита
        private List<double> payments = new List<double>(); // История платежей

        private void z4_Click(object sender, RoutedEventArgs e)
        {
            if (hol.Text == "" || rol.Text == "")
            {
                MessageBox.Show("Заполните все значения", "Учёт платежей", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // После первого ввода отключаем редактирование сумму кредита
            if (creditSum == 0)
            {
                creditSum = double.Parse(hol.Text);
                hol.IsEnabled = false;
            }

            AddPayment(double.Parse(rol.Text));
            rol.Text = "";
        }

        private void AddPayment(double paySum)
        {
            payments.Add(paySum);

            // Сколько выплачено всего: суммируем все платежи
            double totalPayed = payments.Sum();

            // Задолженность
            double debt;
            if (creditSum > totalPayed)
                debt = creditSum - totalPayed;
            else
                debt = 0;

            // Переплата
            double overpayment;
            if (totalPayed > creditSum)
                overpayment = totalPayed - creditSum;
            else
                overpayment = 0;

            // Состояние кредита
            string txt;
            if (debt <= 0)
                txt = "Долг отсутсвует";
            else
                txt = "Есть долг";

            MessageBox.Show("Cумма задолженности: " + debt + "; Сумма переплаты: " + overpayment + "; Долг: " + txt);
        }


        private void z5_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tol.Text);
            int i = 1;
            int sum = 1;
            LB1: if (i <= n)
            {
                sum *= i;
                i++;
                goto LB1;
            }
            else
                sol.Content = sum;
        }
    }
}
