using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Controls.Primitives;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TrigMeter.Resources;
using System.Windows.Shapes;
using System.Windows.Media;


namespace TrigMeter
{
    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float a = 0, b = 0, c = 0, total = 0;

            if (C.Text.Trim().Length == 0)
            {
                a = float.Parse(A.Text);
                b = float.Parse(B.Text);
                //c = float.Parse(C.Text);
               c = (float)Math.Sqrt(a * a + b * b);
                C.Text = c.ToString();
            }
            else if (A.Text.Trim().Length == 0)
            {
                c = float.Parse(C.Text);
                b = float.Parse(B.Text);
                //c = float.Parse(C.Text);
                a = (float)Math.Sqrt(c * c - b * b);
                A.Text =a.ToString();
           }
            else if (B.Text.Trim().Length == 0)
            {
                c = float.Parse(C.Text);
                a = float.Parse(A.Text);
                //c = float.Parse(C.Text);
                b = (float)Math.Sqrt(c * c - a * a);
                B.Text =b.ToString();
            }
            else if ((B.Text.Trim().Length == 0 && A.Text.Trim().Length == 0) || (B.Text.Trim().Length == 0 && C.Text.Trim().Length == 0) || (C.Text.Trim().Length == 0 && A.Text.Trim().Length == 0))
            {
                MessageBox.Show("Not enough data!", "", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("One box must be empty!", "", MessageBoxButton.OK);
                clear();

            }
            C1.Text =RTD(Math.Acos( ((float)(b * b + c * c - a * a) / (float)(2 * b * c)))).ToString() ;
            C2.Text = RTD(Math.Acos( ((float)(-b * b + c * c + a * a) / (float)(2 * a * c)))).ToString() ;
            drw();
        }

        private double DTR(double angle)
        {
            return (Math.PI * angle) / 180.0;
        }

        private void clear()
        {
            A.Text = "";
            B.Text = "";
            C.Text = "";
            C1.Text = "";
            C2.Text = "";
        }

        private void drw()
        {
            

            Line line = new Line();
            line.Stroke = new SolidColorBrush(Colors.White);
            line.StrokeThickness = 3;

            line.X1 = Canvas.GetLeft(Draw) ;
            line.X2 = Canvas.GetLeft(Draw) + Draw.Height;

            line.Y1 = Canvas.GetTop(Draw);
            line.Y2 = Canvas.GetTop(Draw) + Draw.Height;

            Draw.Children.Add(line);
          //  LayoutRoot.Children.Add(line);
        }
        private double RTD(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void Panorama_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}