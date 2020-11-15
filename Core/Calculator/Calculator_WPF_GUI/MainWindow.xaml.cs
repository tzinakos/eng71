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
using Calculator;

namespace Calculator_WPF_GUI
{ /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inputPanel.Text = "0";           
        }

      

        private void outputPanel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Below Are The Button Functions
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "1";
            }
            else 
            inputPanel.Text += "1";
            

        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "2";
            }
            else
                inputPanel.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "3";
            }
            else
                inputPanel.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "4";
            }
            else
                inputPanel.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "5";
            }
            else
                inputPanel.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "6";
            }
            else
                inputPanel.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "7";
            }
            else
                inputPanel.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "8";
            }
            else
                inputPanel.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "9";
            }
            else
                inputPanel.Text += "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "0")
            {
                ErrorPanel.Text = "";
                inputPanel.Text = "0";
            }
            else
                inputPanel.Text += "0";
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            var num = Convert.ToDouble(inputPanel.Text);
            inputPanel.Text = num == Math.Abs(num) ? "-" + num.ToString() : "+" + num.ToString(); // if the value is iqual to its ubsolute value then it is a positive one thus we turn it in to a negative
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text is null)
            {
                return; // if the input textField is empty then exit the method
            }
            else inputPanel.Text += ".";

        }

        private void Modulo_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "")
            {
                return;
            }
            else
            {
                double number = Convert.ToDouble(inputPanel.Text);
                inputPanel.Text = (number / 100).ToString();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text != "")
            {
                inputPanel.Text = inputPanel.Text.Remove(inputPanel.Text.Length - 1); // it Deletes the last character of the string
            }
           
        }

        private void ClearOutputPanel_Click(object sender, RoutedEventArgs e) // clears the input textfield
        {
            inputPanel.Text = "";
           
        }

        private void ClearOutputPanelAndHistory_Click(object sender, RoutedEventArgs e) // restarts the calc
        {
            inputPanel.Text = "";
            HistoryPanel.Text = "";
            ErrorPanel.Text = "";
            CalculatorLib.opperants.Clear();
            
        }

        private void Brackets_Click(object sender, RoutedEventArgs e) // checking if there are previuse open brackers if there are then add a closing bracket else add an opening bracket
        {
            var counter = 0;
            foreach (char x in inputPanel.Text)
            {
                if (x == '(')
                {
                    counter = 1;
                }
                else if (x == ')') { counter = 0; }
            }
            if (counter == 0)
            {
                inputPanel.Text += " ( ";
            }
            else inputPanel.Text += " ) ";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (HistoryPanel.Text=="")
            {
                return;
            }
            char x = HistoryPanel.Text[HistoryPanel.Text.Length - 2];
            switch (x)
            {
                case '+':
                    if (ErrorPanel.Text == "")
                    {
                        ErrorPanel.FontSize = 40;
                        string s = HistoryPanel.Text.Replace(" + ", "");
                        ErrorPanel.Text = (Math.Round(double.Parse(s) + double.Parse(inputPanel.Text))).ToString();
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();           
                    }
                    else
                    {
                        ErrorPanel.FontSize = 40;

                        ErrorPanel.Text = (double.Parse(ErrorPanel.Text) + double.Parse(inputPanel.Text)).ToString();
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();                     
                    }
                    break;

                case '-':
                    if (ErrorPanel.Text == "")
                    {
                        ErrorPanel.FontSize = 40;
                        string s = HistoryPanel.Text.Replace(" - ", "");
                        ErrorPanel.Text = (Math.Round(double.Parse(s) - double.Parse(inputPanel.Text))).ToString();
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();

                    }
                    else
                    {
                        ErrorPanel.FontSize = 40;

                        ErrorPanel.Text = (double.Parse(ErrorPanel.Text) - double.Parse(inputPanel.Text)).ToString();
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();
                    }
                    break;
                case '*':
                    if (ErrorPanel.Text == "")
                    {
                        ErrorPanel.FontSize = 40;
                        string s = HistoryPanel.Text.Replace(" * ", "");
                        ErrorPanel.Text = (Math.Round(double.Parse(s) * double.Parse(inputPanel.Text))).ToString();
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();
                    }
                    else
                    {
                        ErrorPanel.FontSize = 40;

                        ErrorPanel.Text = (double.Parse(ErrorPanel.Text) * double.Parse(inputPanel.Text)).ToString();
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();
                    }
                    break;
                case '/':
                    if (inputPanel.Text == "0")
                    {
                        ErrorPanel.Text = "I am Sorry, You can not divide by 0 :(";
                    }
                    else
                    {
                        if (ErrorPanel.Text == "")
                        {
                            ErrorPanel.FontSize = 40;
                            string s = HistoryPanel.Text.Replace(" / ", "");
                            ErrorPanel.Text = (double.Parse(s) / double.Parse(inputPanel.Text)).ToString();
                            inputPanel.Text = "0";
                            HistoryPanel.Text = "";
                            CalculatorLib.opperants.Clear();
                        }
                        else
                        {
                            ErrorPanel.FontSize = 40;

                            ErrorPanel.Text = (double.Parse(ErrorPanel.Text) / double.Parse(inputPanel.Text)).ToString();
                            inputPanel.Text = "0";
                            HistoryPanel.Text = "";
                            CalculatorLib.opperants.Clear();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void HistoryPanel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            doOperation('+');
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            doOperation('-');
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            doOperation('*');
        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            doOperation('/');
        }

        private void doOperation(char operation)
        {
            if (inputPanel.Text == "0" && HistoryPanel.Text == "" && ErrorPanel.Text != "")
            {
                HistoryPanel.Text = ErrorPanel.Text + $" {operation} ";

                ErrorPanel.Text = "";
                ErrorPanel.FontSize = 15;
            }
            else
            {
                switch (operation)
                {
                    case '+': ErrorPanel.Text = CalculatorLib.Add(double.Parse(inputPanel.Text));
                        break;
                    case '-':
                        ErrorPanel.Text = CalculatorLib.Subtract(double.Parse(inputPanel.Text));
                        break;
                    case '*':
                        ErrorPanel.Text = CalculatorLib.Multiply(double.Parse(inputPanel.Text));
                        break;
                    case '/':
                        ErrorPanel.Text = CalculatorLib.Divide(double.Parse(inputPanel.Text));
                        break;
                    case '%':
                        ErrorPanel.Text = CalculatorLib.Add(double.Parse(inputPanel.Text));
                        break;

                    default:
                        break;
                }
                if (ErrorPanel.Text != "")
                {
                    HistoryPanel.Text = ErrorPanel.Text + $" {operation} ";

                }
                else HistoryPanel.Text = inputPanel.Text + $" {operation} ";
                inputPanel.Text = "0";
            }
        }       
    }  
}
