using Calculator.Classes;
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

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
      
        double lastValue;
        double result;
        SelectedOperator selectedOperator;
        private int Flag;
        private int Flag2;
        private double tmp =0;

        public enum SelectedOperator
        {
            Addition, Substraction, Multipication, Division
        }
        public MainWindow()
        {
            InitializeComponent();
            acButton.Click += AcButton_Click;
            pmButton.Click += PmButton_Click;
            percentButton.Click += PecentButton_Click; 
            equalButton.Click += EqualButton_Click;    

        }//이벤트 등록

        //연산자 함수 
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
           //lastValue = double.Parse(resultLable.Content.ToString());
           //resultLable.Content = "0";

            if (double.TryParse(resultLable.Content.ToString(), out lastValue))
            {
                resultLable.Content = "0";
            }
            if (sender == addButton)
            {
                if (Flag == 0)
                {
                    selectedOperator = SelectedOperator.Addition;
                    resultexp.Content += lastValue + "+";
                    Flag++;
                    result = lastValue;
                    tmp += lastValue;
                    Flag2 = 1;
                }
                else
                {
                    if (Flag2 == 1)
                    {
                        selectedOperator = SelectedOperator.Addition;
                        tmp = SimpleMath.Add(tmp, lastValue);
                        resultexp.Content += lastValue + "+";
                    }
                    else if (Flag2 == 2)
                    {
                        selectedOperator = SelectedOperator.Addition;
                        tmp = SimpleMath.Sub(tmp, lastValue);
                        resultexp.Content += lastValue + "+";
                    }
                    else if (Flag2 == 3)
                    {
                        selectedOperator = SelectedOperator.Addition;
                        tmp = SimpleMath.Mul(tmp, lastValue);
                        resultexp.Content += lastValue + "+";
                    }
                    else 
                    {
                        selectedOperator = SelectedOperator.Addition;
                        tmp = SimpleMath.Div(tmp, lastValue);
                        resultexp.Content += lastValue + "+";
                    }

                }
                Flag2 = 1;

            }
            if (sender == subButton)
            {
                if (Flag == 0)
                {
                    selectedOperator = SelectedOperator.Substraction;
                    resultexp.Content += lastValue + "-";
                    Flag++;
                    result = lastValue;
                    tmp += lastValue;
                    Flag2 = 2;
                }
                else
                {
                    if (Flag2 == 1)
                    {
                        selectedOperator = SelectedOperator.Substraction;
                        tmp = SimpleMath.Add(tmp, lastValue);
                        resultexp.Content += lastValue + "-";
                    }
                    else if (Flag2 == 2)
                    {
                        selectedOperator = SelectedOperator.Substraction;
                        tmp = SimpleMath.Sub(tmp, lastValue);
                        resultexp.Content += lastValue + "-";
                    }
                    else if (Flag2 == 3)
                    {
                        selectedOperator = SelectedOperator.Substraction;
                        tmp = SimpleMath.Mul(tmp, lastValue);
                        resultexp.Content += lastValue + "-";
                    }
                    else
                    {
                        selectedOperator = SelectedOperator.Substraction;
                        tmp = SimpleMath.Div(tmp, lastValue);
                        resultexp.Content += lastValue + "-";
                    }

                }
                Flag2 = 2;
            } 
            
            if (sender == mulButton)
            {
                if (Flag == 0)
                {
                    selectedOperator = SelectedOperator.Multipication;
                    resultexp.Content += lastValue + "*";
                    Flag++;
                    result = lastValue;
                    tmp = lastValue;
                    Flag2 = 3;
                }
                else
                {
                    if (Flag2 == 1)
                    {
                        selectedOperator = SelectedOperator.Multipication;
                        tmp = SimpleMath.Add(tmp, lastValue);
                        resultexp.Content += lastValue + "*";
                    }
                    else if (Flag2 == 2)
                    {
                        selectedOperator = SelectedOperator.Multipication;
                        tmp = SimpleMath.Sub(tmp, lastValue);
                        resultexp.Content += lastValue + "*";
                    }
                    else if (Flag2 == 3)
                    {
                        selectedOperator = SelectedOperator.Multipication;
                        tmp = SimpleMath.Mul(tmp, lastValue);
                        resultexp.Content += lastValue + "*";
                    }
                    else
                    {
                        selectedOperator = SelectedOperator.Multipication;
                        tmp = SimpleMath.Div(tmp, lastValue);
                        resultexp.Content += lastValue + "*";
                    }
                }
                Flag2 = 3;

            }
            if (sender == divButton)
            {
                if (Flag == 0)
                {
                    selectedOperator = SelectedOperator.Division;
                    resultexp.Content += lastValue + "/";
                    Flag++;
                    result = lastValue;
                    tmp = lastValue;
                    Flag2 = 4;
                }
                else
                {
                    if (Flag2 == 1)
                    {
                        selectedOperator = SelectedOperator.Division;
                        tmp = SimpleMath.Add(tmp, lastValue);
                        resultexp.Content += lastValue + "/";
                    }
                    else if (Flag2 == 2)
                    {
                        selectedOperator = SelectedOperator.Division;
                        tmp = SimpleMath.Sub(tmp, lastValue);
                        resultexp.Content += lastValue + "/";
                    }
                    else if (Flag2 == 3)
                    {
                        selectedOperator = SelectedOperator.Division;
                        tmp = SimpleMath.Mul(tmp, lastValue);
                        resultexp.Content += lastValue + "/";
                    }
                    else
                    {
                        selectedOperator = SelectedOperator.Division;
                        tmp = SimpleMath.Div(tmp, lastValue);
                        resultexp.Content += lastValue + "/";
                    }
                }
                Flag2 = 4;
            }
           
        }
        //숫자버튼 함수
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;
            if (sender == zerobutton)
            {
                selectedValue = 0;
            }       
            if (sender == onebutton)
            {
                selectedValue = 1;
            }
            if (sender == twobutton)
            {
                selectedValue = 2;
            }
            if (sender == threebutton)
            {
                selectedValue = 3;
            }
            if (sender == fourbutton)
            {
                selectedValue = 4;
            }
            if (sender == fivebutton)
            {
                selectedValue = 5;
            }
            if (sender == sixbutton)
            {
                selectedValue = 6;
            }
            if (sender == sevenbutton)
            {
                selectedValue = 7;
            }
            if (sender == eightbutton)
            {
                selectedValue = 8;
            }
            if (sender == ninebutton)
            {
                selectedValue = 9;
            }

            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = selectedValue.ToString();
            }
            else
            {
                //resultLable.Content += "7"; 
                resultLable.Content = $"{resultLable.Content}{selectedValue}";
            }
        }
        //AC버튼
        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            //delegate void Click (object, RoutedEventArgs)
            resultLable.Content = "0";
            Flag = 0;
            Flag2 = 0;
            tmp = 0;
            lastValue = 0; 

        }
        //부호변환 버튼
        private void PmButton_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(resultLable.Content.ToString());
            value = -value;
            resultLable.Content = value.ToString();
        }
        private void PecentButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLable.Content.ToString(), out lastValue))
            {
                lastValue /= 100;
                resultLable.Content = lastValue.ToString();
            }
        }
        // = 버튼 
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber = 0; 
            double result = double.Parse(resultLable.Content.ToString());
            

            if (double.TryParse(resultLable.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastValue, newNumber);
                        state.Items.Add(resultexp.Content.ToString() + newNumber + "=" + result.ToString());
                        resultexp.Content = "";
                        break;
                    case SelectedOperator.Substraction:
                        result = SimpleMath.Sub(lastValue, newNumber);
                        state.Items.Add(resultexp.Content.ToString() + newNumber + "=" + result.ToString());
                        resultexp.Content = "";
                        break;
                    case SelectedOperator.Multipication:
                        result = SimpleMath.Mul(lastValue, newNumber);
                        state.Items.Add(resultexp.Content.ToString() + newNumber + "=" + result.ToString());
                        resultexp.Content = "";
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Div(lastValue, newNumber);
                        state.Items.Add(resultexp.Content.ToString() + newNumber + "=" + result.ToString());
                        resultexp.Content = "";
                        break;
                }            
                resultLable.Content = result.ToString();
                lastValue = 0;
                tmp = 0;
                Flag = 0;
                Flag2=0;

            }

        }
        // . 버튼 
        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean a;
            a = resultLable.Content.ToString().Contains(".");
            if (resultLable.Content.ToString() == "0")
            {
                return;
            }
            else
            {
                if (a == false)
                {
                    resultLable.Content += ".";
                }
            }
        }
        // DEl Sqrt X^2 1/X
        private void Expandfun_Click(object sender, RoutedEventArgs e)
        {
            if (sender == delButton)
            {
                if (resultLable.Content.ToString().Length != 1)
                {
                    resultLable.Content = resultLable.Content.ToString().
                         Substring(0, resultLable.Content.ToString().Length - 1);
                }
                else
                {
                    resultLable.Content = "0";
                }
            } 
            if (sender == sqrtButton)
            {
                if (double.TryParse(resultLable.Content.ToString(), out lastValue))
                {
                    lastValue = Math.Sqrt(lastValue);
                    resultLable.Content = lastValue.ToString();
                   

                }
            }
            if (sender == powButton)
            {
                if (double.TryParse(resultLable.Content.ToString(), out lastValue))
                {
                    lastValue = SimpleMath.pow(lastValue);
                    resultLable.Content = lastValue.ToString();

                }
            }
            if (sender == revButton)
            {
                if (double.TryParse(resultLable.Content.ToString(), out lastValue))
                {
                    lastValue = SimpleMath.rev(lastValue);
                    resultLable.Content = lastValue.ToString();
                }
            }
        
        }


    }
}
