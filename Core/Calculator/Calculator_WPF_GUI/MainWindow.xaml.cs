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

        bool fnIsEnabled = false;

        private void outputPanel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Below Are The Button Functions

        //Button Click Method For Number One
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

        //Button Click Method For Number Two
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

        //Button Click Method For Number Three
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

        //Button Click Method For Number Four
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

        //Button Click Method For Number Five
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

        //Button Click Method For Number Six
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

        //Button Click Method For Number Seven
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

        //Button Click Method For Number Eight
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

        //Button Click Method For Number Nine
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

        //Button Click Method For Number Zero
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

        //Button Click for the Sign Changer Method
        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            var num = Convert.ToDouble(inputPanel.Text);
            inputPanel.Text = num == Math.Abs(num) ? "-" + num.ToString() : "+" + num.ToString(); // if the value is iqual to its ubsolute value then it is a positive one 
                                                                                                  //thus we turn it in to a negative
        }

        //Button Click for the . Method
        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            
            inputPanel.Text += "."; // adds decimal .

        }


        // Button For The Delete Method
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text != "")
            {
                inputPanel.Text = inputPanel.Text.Remove(inputPanel.Text.Length - 1); // it Deletes the last character of the string
                if (inputPanel.Text == "")
                {
                    inputPanel.Text = "0";
                }
            }
           
        }

        // Method For The CE button: Sets The InputPanel Value to its Default
        private void ClearOutputPanel_Click(object sender, RoutedEventArgs e) // clears the input textfield
        {
            inputPanel.Text = "0"; 
           
        }

        // Method For The C Button: Clears All The Fields and restarts it with default values
        private void ClearOutputPanelAndHistory_Click(object sender, RoutedEventArgs e) // restarts the calc
        {
            inputPanel.Text = "0";
            HistoryPanel.Text = "";
            ErrorPanel.Text = "";
            CalculatorLib.opperants.Clear();
            
        }

        // Brackers To Be Implemented

        //private void Brackets_Click(object sender, RoutedEventArgs e) // checking if there are previuse open brackers if there are then add a closing bracket else add an opening bracket
        //{
        //    var counter = 0;
        //    foreach (char x in inputPanel.Text)
        //    {
        //        if (x == '(')
        //        {
        //            counter = 1;
        //        }
        //        else if (x == ')') { counter = 0; }
        //    }
        //    if (counter == 0)
        //    {
        //        inputPanel.Text += " ( ";
                
        //    }
        //    else inputPanel.Text += " ) ";
        //}


        // Method For The = Button. One Of the Mains.
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            //First It Checkes If the history panel is empty
            if (HistoryPanel.Text=="")
            {
                return; // If it is, It can not compate it; Thus, It returns and continues to the rest of the method.
            }

            //If It is not Empty Then It proceeds With The Operation.
            char x = HistoryPanel.Text[HistoryPanel.Text.Length - 2]; // It Checs For A sign In Order to do the correct opperation.
            switch (x) // Possible Cases For This Swich are 1: '+', 2: '-', 3: '*', 4: '/'
            {
                //In case x = '+'
                case '+':
                    if (ErrorPanel.Text == "") //If The Output panel = null
                    {
                        ErrorPanel.FontSize = 30; // Sets The Font Of the Output Panel to 30px
                        string s = HistoryPanel.Text.Replace(" + ", ""); // The historyPanel.Text would be "x + " And we transform it to "x"
                        ErrorPanel.Text = CalculatorLib.Add(double.Parse(s), double.Parse(inputPanel.Text)).ToString(); // Calls The Addition method From The CalculatorLib Class to perform the Addition. 
                        historyList.Items.Add($"{HistoryPanel.Text}{inputPanel.Text} = {ErrorPanel.Text}"); // Adds The Operation to the History List
                       
                        //Resets The fields to their default
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                       
                        //Resets The Opperants List
                        CalculatorLib.opperants.Clear();           
                    }
                    else
                    {
                        ErrorPanel.FontSize = 30;// Sets The Font Of the Output Panel to 30px
                        ErrorPanel.Text = CalculatorLib.Add(double.Parse(ErrorPanel.Text), double.Parse(inputPanel.Text)).ToString(); // Calls The Addition method From The CalculatorLib Class to perform the Addition.
                        
                        //Resets The fields to their default
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";

                        //Resets The Opperants List
                        CalculatorLib.opperants.Clear();                     
                    }
                    break;

                case '-':
                    if (ErrorPanel.Text == "")
                    {
                        ErrorPanel.FontSize = 30;
                        string s = HistoryPanel.Text.Replace(" - ", "");
                        ErrorPanel.Text = (Math.Round(double.Parse(s) - double.Parse(inputPanel.Text))).ToString();
                        historyList.Items.Add($"{HistoryPanel.Text}{inputPanel.Text} = {ErrorPanel.Text}");
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();

                    }
                    else
                    {
                        ErrorPanel.FontSize = 30;

                        ErrorPanel.Text = (double.Parse(ErrorPanel.Text) - double.Parse(inputPanel.Text)).ToString();
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();
                    }
                    break;
                case '*':
                    if (ErrorPanel.Text == "")
                    {
                        ErrorPanel.FontSize = 30;
                        string s = HistoryPanel.Text.Replace(" * ", "");
                        ErrorPanel.Text = (Math.Round(double.Parse(s) * double.Parse(inputPanel.Text))).ToString();
                        historyList.Items.Add($"{HistoryPanel.Text}{inputPanel.Text} = {ErrorPanel.Text}");
                        inputPanel.Text = "0";
                        HistoryPanel.Text = "";
                        CalculatorLib.opperants.Clear();
                    }
                    else
                    {
                        ErrorPanel.FontSize = 30;

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
                            ErrorPanel.FontSize = 30;
                            string s = HistoryPanel.Text.Replace(" / ", "");
                            ErrorPanel.Text = (double.Parse(s) / double.Parse(inputPanel.Text)).ToString();
                            historyList.Items.Add($"{HistoryPanel.Text}{inputPanel.Text} = {ErrorPanel.Text}");
                            inputPanel.Text = "0";
                            HistoryPanel.Text = "";
                            CalculatorLib.opperants.Clear();
                        }
                        else
                        {
                            ErrorPanel.FontSize = 30;

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

        //Addition Trigger Button
        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            
            doOperation(ChechForOperation('+'),'+');
        }

        //Subtraction Trigger Button
        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
           
            doOperation(ChechForOperation('-'),'-');
        }

        //Multiplication / Power of 2 Trigger Button
        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (fnIsEnabled)
            {
                doOperation('p', ' ');
            }
            else
            {
                doOperation(ChechForOperation('*'), '*');
            }
        }

        //Division / SquareRoot Trigger Button
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (fnIsEnabled)
            {
                doOperation('s', ' ');              
            }
            else
            {
                doOperation(ChechForOperation('/'), '/');
            }
        }
        //Percentage Method !!!
        private void Percentage_Click(object sender, RoutedEventArgs e)
        {
            doOperation('%', ' ');
          
        }

        //Checks For Operations that are in Queue, if there are none then proceed with the triggered operation.
        private char ChechForOperation(char theDefaut)
        {
            char result = theDefaut;
            if (HistoryPanel.Text != "")
            {
                result = HistoryPanel.Text[HistoryPanel.Text.Length - 2];
            }
            return result;
        }


        private void doOperation(char operation, char symbol)
        {
            //If there is no current operation, but there exists the result of the previus one, then operate on that.
            if (inputPanel.Text == "0" && HistoryPanel.Text == "" && ErrorPanel.Text != "")
            {
                if (ErrorPanel.Text.Length > 5)
                {
                    HistoryPanel.Text = $"{ErrorPanel.Text.Substring(ErrorPanel.Text.IndexOf('=') + 1)} {symbol} ";

                    ErrorPanel.Text = "";
                    ErrorPanel.FontSize = 15;
                } else 
                { 
                    CalculatorLib.opperants.Clear();
                    CalculatorLib.opperants.Add(double.Parse(ErrorPanel.Text));
                    HistoryPanel.Text = $"{ErrorPanel.Text.Substring(ErrorPanel.Text.IndexOf('=') + 1)} {symbol} ";

                    ErrorPanel.Text = "";
                    ErrorPanel.FontSize = 15;
                }             
                
            }
            else
            {
                switch (operation) // There are 7 possible Cases All of them Calling the according method from the CalculatorLib Class
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
                        string evaluationByZeroText = CalculatorLib.Divide(double.Parse(inputPanel.Text));
                        if (evaluationByZeroText == "01")
                        {
                            ErrorPanel.Text = "I am Sorry, You can Not Divide By 0 :( ";
                        }
                        else
                            ErrorPanel.Text = evaluationByZeroText;
                        break;
                    case '%':
                        ErrorPanel.Text = CalculatorLib.Percentage(double.Parse(inputPanel.Text));
                        break;
                    case 'p':
                        ErrorPanel.Text = CalculatorLib.PowerOfTwo(double.Parse(inputPanel.Text));
                        break;
                    case 's':
                        ErrorPanel.Text = CalculatorLib.SquareRoot(double.Parse(inputPanel.Text));
                        break;
                   
                }
                if (ErrorPanel.Text != "")
                {
                    historyList.Items.Add($"{HistoryPanel.Text}{inputPanel.Text} = {ErrorPanel.Text}");
                    HistoryPanel.Text = ErrorPanel.Text + $" {symbol} ";
                   
                    inputPanel.Text = "0";

                }
                else
                {
                    if (HistoryPanel.Text == "")
                    {
                        HistoryPanel.Text = inputPanel.Text + $" {symbol} ";
                        inputPanel.Text = "0";
                    }
                    else
                    {
                        historyList.Items.Add($"{HistoryPanel.Text}{inputPanel.Text} = {ErrorPanel.Text}");
                        HistoryPanel.Text = inputPanel.Text + $" {symbol} ";
                       
                        inputPanel.Text = "0";
                    }                               
                }
            }
        }

        // History List Toggle Method
        private void History_Click(object sender, RoutedEventArgs e)
        {
            
            historyList.IsEnabled = historyList.IsEnabled ? false : true;

        }

        private void HistoryPanel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Takes The Doubled Clicked Item From The History And Allow it To do Further Operations On its Result.
        private void OnListClick(object sender, MouseButtonEventArgs  e)
        {
            var item = (sender as ListBox).SelectedItem;
            if (item != null)
            {                         
                inputPanel.Text = "0";
                HistoryPanel.Text = "";
                ErrorPanel.Text = item.ToString().Substring(item.ToString().IndexOf(':') + 1); 
                CalculatorLib.opperants.Clear();
               
                double papas = double.Parse(ErrorPanel.Text.Substring(ErrorPanel.Text.IndexOf('=')+1));
                CalculatorLib.Add(papas);
            }
        }

        //FN Toggle Button.
        private void Fn_Click(object sender, RoutedEventArgs e)
        {
            if (fnIsEnabled)
            {
                Division.Content = "/";
                Multiplication.Content = "X";
                fnIsEnabled = false;
                
            }
            else
            {
                Division.Content = "√x";
                Multiplication.Content = "x²";
                
                fnIsEnabled = true;
            }
        }
    }  
}
