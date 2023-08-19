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

namespace TWCalculator.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float LOperand;
        float ROperand;
        bool point;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "1";
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "2";
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "3";
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "4";
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "5";
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "6";
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "7";
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "8";
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "9";
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputField.Text)) InputField.Text += "0";
        }

        private void btPoint_Click(object sender, RoutedEventArgs e)
        {
            if(!point)
            {
                if(string.IsNullOrEmpty(InputField.Text))
                {
                    InputField.Text = "0,";
                }
                else
                {
                    InputField.Text += ",";
                    point = true;
                }                
            }
        }
    }
}
