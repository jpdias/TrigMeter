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
            if ((B1 != null) && (B2 != null))
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
            if ((C1 != null) && (C2 != null))
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
            if ((D1 != null) && (D2 != null))
                R3.Text = (float.Parse(C1.Text) * float.Parse(C2.Text)).ToString();
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }

        }

        private void Calc4(object sender, RoutedEventArgs e)
        {
            if ((E1 != null) && (E2 != null) && (E3 != null))
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
            if (F1 != null)
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
    }
}