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
    }
}
