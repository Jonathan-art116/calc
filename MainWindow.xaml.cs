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

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick0(object sender, RoutedEventArgs e)
        {
            if(result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "0";
                }
                else
                {
                    result.Text += "0";
                }
            }
            else
            {
                result.Text = "0";
            }
        }

        private void OnClick1(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "1";
                }
                else
                {
                    result.Text += "1";
                }
            }
        }

        private void OnClick2(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "2";
                }
                else
                {
                    result.Text += "2";
                }
            }
        }

        private void OnClick3(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "3";
                }
                else
                {
                    result.Text += "3";
                }
            }
        }

        private void OnClick4(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "4";
                }
                else
                {
                    result.Text += "4";
                }
            }
        }

        private void OnClick5(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "5";
                }
                else
                {
                    result.Text += "5";
                }
            }
        }

        private void OnClick6(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "6";
                }
                else
                {
                    result.Text += "6";
                }
            }
        }

        private void OnClick7(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "7";
                }
                else
                {
                    result.Text += "7";
                }
            }
        }

        private void OnClick8(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "8";
                }
                else
                {
                    result.Text += "8";
                }
            }
        }

        private void OnClick9(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 7)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "9";
                }
                else
                {
                    result.Text += "9";
                }
            }
        }

        private void OnClickP(object sender, RoutedEventArgs e)
        {
            if (result.Text.IndexOf(".") == -1)
            {
                result.Text += ".";
            }
        }

        private void OnClickE(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickplus(object sender, RoutedEventArgs e)
        {
            
        }

        private void OnClickM(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickMult(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickClear(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
        }

        private void OnClickPO(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length >= 1 && result.Text.Length < 9)
            {
                if (result.Text.Substring(0, 1) == "0" && result.Text.IndexOf(".") == -1)
                {
                    result.Text = "0";
                }
                else if (result.Text.Substring(0, 1) == "-")
                {
                    string s1 = result.Text;
                    result.Text = s1.Remove(0,1);
                }
                else if (result.Text.Substring(0, 1) != "-")
                {
                    string s = result.Text;
                    result.Text = s.Insert(0, "-");
                }
            }
        }

        private void OnClickPer(object sender, RoutedEventArgs e)
        {
            string s2 = result.Text;
            float a = Convert.ToSingle(s2) / 100;
            result.Text = a + "";
        }

        private void OnClickDivi(object sender, RoutedEventArgs e)
        {

        }
    }               
}                   