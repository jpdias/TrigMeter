using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace TrigMeter
{

    public partial class Solve : PhoneApplicationPage
    {
        public Solve()
        {
            InitializeComponent();
        }

        private double num;
        private void calc_Click(object sender, RoutedEventArgs e)
        {
            if (A.Text.Trim().Length != 0 && B.Text.Trim().Length != 0 && C.Text.Trim().Length != 0
                && double.TryParse(A.Text, out num) && double.TryParse(B.Text, out num) && double.TryParse(C.Text, out num))
                 SolveQuadratic(double.Parse(A.Text), double.Parse(B.Text), double.Parse(C.Text));
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
                return;
            }
        }

        private void SolveQuadratic(double a, double b, double c)
        {

            double sqrtpart = b * b - 4 * a * c;

            double x, x1, x2, img;

            if (sqrtpart > 0)
            {

                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                R1.Text = Math.Round(x1,5).ToString();
                R2.Text = Math.Round(x2,5).ToString();
                // Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);

            }

            else if (sqrtpart < 0)
            {

                sqrtpart = -sqrtpart;

                x = -b / (2 * a);

                img = System.Math.Sqrt(sqrtpart) / (2 * a);

                R1.Text = x + " + " + Math.Round(img,4) + " i";
                R2.Text = x + " - " + Math.Round(img,4) + " i";
               // Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);

            }

            else
            {

                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                R1.Text =Math.Round( x,10).ToString();
                R2.Text = "Null";
                //  Console.WriteLine("One Real Solution: {0,8:f4}", x);

            }

        }

        private void Clr_Click(object sender, RoutedEventArgs e)
        {
            B.Text = "";
            A.Text = "";
            C.Text = "";
            R1.Text = "";
            R2.Text = "";
        }

 
    }
}