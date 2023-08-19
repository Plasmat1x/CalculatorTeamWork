using CalcTW;
using System.Windows;
using System.Windows.Input;

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
        bool Res; // not implemented

        delegate Result Operation(float l, float r);

        Operation operation;

        Calculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "1";
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "2";
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "3";
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "4";
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "5";
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "6";
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "7";
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "8";
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
            InputField.Text += "9";
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            if (Res)
            {
                InputField.Text = "";
                Res = false;
            }
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
            if (operation == null)
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
        }

        private void btDim_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
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
        }

        private void btMult_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
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
        }

        private void btDiv_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
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

                opHistory.Content += ROperand.ToString();
            }

            Point = false;
            Res = true;
            operation = null;
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

        private void btInverse_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InputField.Text))
            {
                float tmp;
                float.TryParse(InputField.Text, out tmp);
                tmp *= -1;
                InputField.Text = tmp.ToString();
            }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //digits
            if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                bt1_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                bt2_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                bt3_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                bt4_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                bt5_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                bt6_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                bt7_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                bt8_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                bt9_Click(sender, e);
                return;
            }
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                bt0_Click(sender, e);
                return;
            }

            //operations
            if (e.Key == Key.Subtract)
            {
                btDim_Click(sender, e);
                return;
            }
            if (e.Key == Key.Add)
            {
                btAdd_Click(sender, e);
                return;
            }
            if (e.Key == Key.Divide)
            {
                btDiv_Click(sender, e);
                return;
            }
            if (e.Key == Key.Multiply)
            {
                btMult_Click(sender, e);
                return;
            }
            if (e.Key == Key.Enter)
            {
                btRes_Click(sender, e);
                return;
            }
            if (e.Key == Key.Back)
            {
                btRes_Click(sender, e);
                return;
            }
        }

        private void btBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (InputField.Text.Length != 0)
            {
                InputField.Text = InputField.Text.Substring(0, InputField.Text.Length - 1);
            }
        }
    }
}
