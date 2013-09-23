using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TrigMeter
{
    public partial class Areas : PhoneApplicationPage
    {
        public Areas()
        {
            InitializeComponent();
        }

        private void Calc1_Click(object sender, RoutedEventArgs e)
        {
            if ((B1.Text.Trim().Length != 0) && (B2.Text.Trim().Length != 0))
                R1.Text = ((float.Parse(B1.Text)*float.Parse(B2.Text))/2).ToString(CultureInfo.InvariantCulture);
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }
        }

        private void Clr1_Click(object sender, RoutedEventArgs e)
        {
            B1.Text = "";
            B2.Text = "";
            R1.Text = "";
        }

        private void Clr2(object sender, RoutedEventArgs e)
        {
            C1.Text = "";
            C2.Text = "";
            R2.Text = "";
        }

        private void Calc2(object sender, RoutedEventArgs e)
        {
            if ((C1.Text.Trim().Length != 0) && (C2.Text.Trim().Length != 0))
                R2.Text = (float.Parse(C1.Text)*float.Parse(C2.Text)).ToString();
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }
        }

        private void Clr3(object sender, RoutedEventArgs e)
        {
            D1.Text = "";
            D2.Text = "";
            R3.Text = "";
        }

        private void Calc3(object sender, RoutedEventArgs e)
        {
            if ((D1.Text.Trim().Length != 0) && (D2.Text.Trim().Length != 0))
                R3.Text = (float.Parse(C1.Text) * float.Parse(C2.Text)).ToString();
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }

        }

        private void Calc4(object sender, RoutedEventArgs e)
        {
            if ((E1.Text.Trim().Length != 0) && (E2.Text.Trim().Length != 0) && (E3.Text.Trim().Length != 0))
            {
                R4.Text = (((float.Parse(E1.Text)*float.Parse(E2.Text))/2.0)*float.Parse(E3.Text)).ToString();
               
            }
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }
        }

        private void Clr4(object sender, RoutedEventArgs e)
        {
            E1.Text = "";
            E2.Text = " ";
            E3.Text = "";
            R4.Text = "";
           

        }

        private void Clr5(object sender, RoutedEventArgs e)
        {
            F1.Text = "";
            R5.Text = "";
        }

        private void Calc5(object sender, RoutedEventArgs e)
        {
            if (F1.Text.Trim().Length!=0)
            {
                if (Rad.IsChecked == true)
                    R5.Text =  (Math.PI*float.Parse(F1.Text)*float.Parse(F1.Text)).ToString();
                else if (Dia.IsChecked == true)
                    R5.Text =(Math.PI*float.Parse(F1.Text)/2*float.Parse(F1.Text)/2).ToString();

                else
                {
                    MessageBox.Show("No data!", "", MessageBoxButton.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }
        }

        private void Calc7(object sender, RoutedEventArgs e)
        {
            if (F7.Text.Trim().Length != 0 && F17.Text.Trim().Length != 0)
            {
                if (Rad1.IsChecked == true)
                {
                    R7.Text = (Math.PI * float.Parse(F7.Text) * float.Parse(F17.Text)).ToString();
                    
                }
                    
                else if (Dia1.IsChecked == true)
                    R7.Text = (Math.PI * float.Parse(F7.Text) / 2 * float.Parse(F17.Text) / 2).ToString();

                else
                {
                    MessageBox.Show("No data!", "", MessageBoxButton.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }
        }

        private void Clr7(object sender, RoutedEventArgs e)
        {
            F17.Text = "";
            F7.Text = "";
            R7.Text = "";
        }

        private void Calc8(object sender, RoutedEventArgs e)
        {
            if (F8.Text.Trim().Length != 0 && F18.Text.Trim().Length != 0)
            {
                var tan = new double();
                tan = Math.Tan(Math.PI/double.Parse(F8.Text));
                R8.Text = (double.Parse(F8.Text) * float.Parse(F18.Text) * float.Parse(F18.Text) /
                      (tan*4)).ToString();
            }
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                
            }
           
        }

        private void Clr8(object sender, RoutedEventArgs e)
        {
            R8.Text = "";
            F8.Text = "";
            F18.Text = "";
        }
    }
}