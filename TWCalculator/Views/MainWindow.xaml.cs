using CalcTW;
using System.Windows;

namespace TWCalculator.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float LOperand;
        float ROperand;

        bool Point;

        public delegate Result Operation(float l, float r);

        Operation operation;

        Calculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(inputField.Text))
            {
                float.TryParse(inputField.Text, out LOperand);
                inputField.Text = "";
                operation = calculator.Add;
            }

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            inputField.Text += "2";
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            inputField.Text += "1";
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            inputField.Text += "3";
        }

        private void btRes_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(inputField.Text))
            {
                float.TryParse(inputField.Text, out ROperand);

                Result res = operation.Invoke(LOperand, ROperand);

                if (res.status == Status.SUCCESS)
                {
                    inputField.Text = res.Value.ToString();
                }
                else
                {
                    inputField.Text = "ERROR";
                }
            }
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
