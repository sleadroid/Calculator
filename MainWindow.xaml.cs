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

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        int first;
        int second;
        char op;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();
            second = Int32.Parse(TxtResult.Text);
        }
        private void Button_Click_Zero(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text += "0";
            second = Int32.Parse(TxtResult.Text);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            TxtLog.Text = TxtResult.Text;
            first = Int32.Parse(TxtResult.Text);
            op = '+';
            TxtLog.Text += "+";
            TxtResult.Clear();
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            TxtLog.Text = TxtResult.Text;
            first = Int32.Parse(TxtResult.Text);
            op = '-';
            TxtLog.Text += "-";
            TxtResult.Clear();
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            TxtLog.Text = TxtResult.Text;
            first = Int32.Parse(TxtResult.Text);
            op = '*';
            TxtLog.Text += "*";
            TxtResult.Clear();
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            TxtLog.Text = TxtResult.Text;
            first = Int32.Parse(TxtResult.Text);
            op = '/';
            TxtLog.Text += "/";
            TxtResult.Clear();
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            TxtResult.Clear();
            TxtLog.Text = "";
        }

        private void ButtonEqu_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(TxtResult.Text);
            int result = 0;

            if (op == '+')
            {
                result = first + second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            TxtLog.Text += second + "=";
            TxtResult.Text = result.ToString();
        }
    }
}
