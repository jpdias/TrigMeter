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
            if (B1 != null)
                if (B2 != null)
                    R1.Text = ((float.Parse(B1.Text)*float.Parse(B2.Text))/2).ToString(CultureInfo.InvariantCulture);
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
            if (C1 != null) if (C2 != null) R2.Text = (float.Parse(C1.Text)*float.Parse(C2.Text)).ToString();
        }
    }
}