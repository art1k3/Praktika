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

namespace zadanie4
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
        private void count_Click(object sender, RoutedEventArgs e) //задание 1
        {
            int A = Convert.ToInt32(a.Text);
            int B = Convert.ToInt32(b.Text);
            int sum = 0;
            for (int i = A + 1; i < B; i++)
            {
                sum += i;
            }
            answer.Content = sum;

            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 1)
                {
                    answer2.Content += $"{i}: ";
                }
            }
        }

        private void count2_Click(object sender, RoutedEventArgs e) //задани 3
        {
            for (int i = 10; i <= 20; i++)
            {
                answer3.Content += $"{Math.Pow(i, 2)}: ";
            }
        }

        private void count3_Click(object sender, RoutedEventArgs e) //задание 4
        {
            int n = Convert.ToInt32(number1.Text);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            answer4.Content = sum;
        }

        private void countPrize_Click(object sender, RoutedEventArgs e) // задание 5 
        {
            try
            {
                int Age = Convert.ToInt32(age.Text);
                if (Age < 5 && Age > 0)
                    answerPrize.Content = "Премия составляет 10% от заработной платы.";
                else if (Age >= 5 && Age < 10)
                    answerPrize.Content = "Премия составляет 15% от заработной платы.";
                else if (Age >= 10 && Age < 15)
                    answerPrize.Content = "Премия составляет 25% от заработной платы.";
                else if (Age >= 15 && Age < 20)
                    answerPrize.Content = "Премия составляет 35% от заработной платы.";
                else if (Age >= 20 && Age < 25)
                    answerPrize.Content = "Премия составляет 45% от заработной платы.";
                else if (Age >= 25)
                    answerPrize.Content = "Премия составляет 50% от заработной платы.";
                else if (Age < 0)
                    answerPrize.Content = "Выслуга лет не может быть отрицательной.";
            }
            catch
            {
                answerPrize.Content = "Error";
            }

        }

        private void countFactorial_Click(object sender, RoutedEventArgs e) // задание 6
        {
            int n = Convert.ToInt32(factorial.Text);
            int i = 1;
            int sum = 1;
            LB1: if (i <= n)
            {
                sum *= i;
                i++;
                goto LB1;
            }
            else
                answerFactorial.Content = $"Факториал числа {n} = {sum}.";
        }

        
    }
}
