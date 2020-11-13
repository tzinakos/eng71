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


namespace CalculatorWPFGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inputPanel.Text = "";
            if (inputPanel.Text=="")
            {
                EnableDisable(false);
                            
            }

            
            
        }

        bool equality = false; // it turns true when the equals button is pressed

        public double Add(double a, double b) // addition method
        {
            return a + b;
        }
        List<double> addArray = new List<double>();
        public void Add(double a) // stores the numbers to an array
        {
            
            addArray.Add(a);
            if (addArray.Count == 2) // when the aray contains 2 numbers then we can purform the addition
            {
                ErrorPanel.Text = (Add(addArray[0], addArray[1])).ToString(); //displaying the result to the error panel
                List<double> temp = new List<double>() { addArray[0], addArray[1] }; // creating a temp arrayList to store temporary the values of the addArray.
                addArray.Clear(); // empties the values from the array
                addArray.Add(Add(temp[0], temp[1])); // ads the summary result to the arrayList
                temp.Clear(); // empty the temporary arrayList

            }
        }
        public  void EnableDisable(bool enable) // if there are no operants then the operators are desabled
        {
            
                Addition.IsEnabled = enable;
                Subtraction.IsEnabled = enable;
                Division.IsEnabled = enable;
                Multiplication.IsEnabled = enable;
                Modulo.IsEnabled = enable;
            
        }

        private void outputPanel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Below Are The Button Functions

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text==""&& equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text  += "1";
            EnableDisable(true);
           
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text  +="2";
            EnableDisable(true);
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "3";
            EnableDisable(true);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "4";
            EnableDisable(true);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "5";
            EnableDisable(true);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "6";
            EnableDisable(true);
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "7";
            EnableDisable(true);
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "8";
            EnableDisable(true);
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "9";
            EnableDisable(true);
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text == "" && equality == true)
            {
                ErrorPanel.Text = "";
                equality = false;
            }
            inputPanel.Text += "0";
            EnableDisable(true);
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            var num = Convert.ToDouble(inputPanel.Text);
            inputPanel.Text = num == Math.Abs(num)? "-"+num.ToString() : "+"+num.ToString(); // if the value is iqual to its ubsolute value then it is a positive one thus we turn it in to a negative
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
            if(inputPanel.Text == "")
            {
                return;
            }
            else
            {
                double number = Convert.ToDouble(inputPanel.Text);
               inputPanel.Text= (number / 100).ToString();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (inputPanel.Text != "")
            {
                inputPanel.Text = inputPanel.Text.Remove(inputPanel.Text.Length - 1); // it teletes the last character of the string
            }
            if(inputPanel.Text == "")
            {
                EnableDisable(false);
            }
        }

        private void ClearOutputPanel_Click(object sender, RoutedEventArgs e) // clears the input textfield
        {
            inputPanel.Text = "";
            EnableDisable(false);
        }

        private void ClearOutputPanelAndHistory_Click(object sender, RoutedEventArgs e) // restarts the calc
        {
            inputPanel.Text = "";
            HistoryPanel.Text = "";
            ErrorPanel.Text = "";
            addArray.Clear();
            EnableDisable(false);
        }

        private void Brackets_Click(object sender, RoutedEventArgs e) // checking if there are previuse open brackers if there are then add a closing bracket else add an opening bracket
        {
            var counter = 0;
            foreach(char x in inputPanel.Text)
            {
                if (x == '(')
                {
                    counter = 1;
                }
                else if (x==')') { counter = 0; }
            }
            if (counter == 0)
            {
                inputPanel.Text += " ( ";
            }
            else inputPanel.Text += " ) ";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {

            char x = HistoryPanel.Text[HistoryPanel.Text.Length-2];
            switch (x)
            {
                case '+':
                    if (ErrorPanel.Text=="") {
                        ErrorPanel.FontSize = 40;
                        ErrorPanel.Text = (double.Parse(HistoryPanel.Text[HistoryPanel.Text.Length - 4].ToString()) + double.Parse(inputPanel.Text)).ToString();
                        inputPanel.Text = "";
                        HistoryPanel.Text = "";
                        addArray.Clear();
                        equality = true;
                    }
                    else
                    {
                        ErrorPanel.FontSize = 40;

                        ErrorPanel.Text = (double.Parse(ErrorPanel.Text) + double.Parse(inputPanel.Text)).ToString();
                        inputPanel.Text = "";
                        HistoryPanel.Text = "";
                        addArray.Clear();                       
                        equality = true;
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

            if (inputPanel.Text == "" && HistoryPanel.Text == "" && ErrorPanel.Text != "")
            {
                HistoryPanel.Text = ErrorPanel.Text + " + ";
                Add(double.Parse(ErrorPanel.Text));
                ErrorPanel.Text = "";
                ErrorPanel.FontSize = 15;
            }
            else
            {
                Add(double.Parse(inputPanel.Text));
                inputPanel.Text += " + ";
                HistoryPanel.Text += inputPanel.Text;
                inputPanel.Text = "";
            }
        }
    }
}
