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



        private void bt1_Click(object sender, RoutedEventArgs e) => InputField.Text += "1";

        private void bt2_Click(object sender, RoutedEventArgs e) => InputField.Text += "2";

        private void bt3_Click(object sender, RoutedEventArgs e) => InputField.Text += "3";

        private void bt4_Click(object sender, RoutedEventArgs e) => InputField.Text += "4";

        private void bt5_Click(object sender, RoutedEventArgs e) => InputField.Text += "5";

        private void bt6_Click(object sender, RoutedEventArgs e) => InputField.Text += "6";

        private void bt7_Click(object sender, RoutedEventArgs e) => InputField.Text += "7";

        private void bt8_Click(object sender, RoutedEventArgs e) => InputField.Text += "8";

        private void bt9_Click(object sender, RoutedEventArgs e) => InputField.Text += "9";

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text += "0";
        }

        private void btPoint_Click(object sender, RoutedEventArgs e)
        {
            if (!Point)
            {
                if (string.IsNullOrEmpty(InputField.Text))
                {
                    InputField.Text = "0,";
                }
                else
                {
                    InputField.Text += ",";
                    Point = true;
                }
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputField.Text))
            {
                float.TryParse(InputField.Text, out LOperand);
                InputField.Text = "";
                operation = calculator.Add;
            }
            opHistory.Content = $"{LOperand} + ";
            Point = false;
        }

        private void btDim_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputField.Text))
            {
                float.TryParse(InputField.Text, out LOperand);
                InputField.Text = "";
                operation = calculator.Sub;
            }
            opHistory.Content = $"{LOperand} - ";
            Point = false;
        }

        private void btMult_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputField.Text))
            {
                float.TryParse(InputField.Text, out LOperand);
                InputField.Text = "";
                operation = calculator.Mul;
            }
            opHistory.Content = $"{LOperand} * ";
            Point = false;
        }

        private void btDiv_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputField.Text))
            {
                float.TryParse(InputField.Text, out LOperand);
                InputField.Text = "";
                operation = calculator.Div;
            }
            opHistory.Content = $"{LOperand} / ";
            Point = false;
        }

        private void btRes_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputField.Text) && operation != null)
            {
                float.TryParse(InputField.Text, out ROperand);

                Result res = operation.Invoke(LOperand, ROperand);

                if (res.status == Status.SUCCESS)
                {
                    InputField.Text = res.Value.ToString();
                }
                else
                {
                    InputField.Text = "ERROR";
                }
            }
            opHistory.Content += ROperand.ToString();
            Point = false;
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            LOperand = 0.0f;
            ROperand = 0.0f;
            Point = false;
            operation = null;
            InputField.Text = "";
            opHistory.Content = "";
        }
    }
}
