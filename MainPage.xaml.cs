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
using System.Text;


namespace TrigMeter
{
    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor

        public MainPage()
        {
            InitializeComponent();
        }


        Point[] pontos = new Point[3];

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float a = 0, b = 0, c = 0;

            if (C.Text.Trim().Length == 0)
            {
                a = float.Parse(A.Text);
                b = float.Parse(B.Text);
                //c = float.Parse(C.Text);
               c = (float)Math.Sqrt(a * a + b * b);
                C.Text = c.ToString();
                angles(a, b, c);
            }
            else if (A.Text.Trim().Length == 0)
            {
                c = float.Parse(C.Text);
                b = float.Parse(B.Text);
                //c = float.Parse(C.Text);
                a = (float)Math.Sqrt(c * c - b * b);
                A.Text =a.ToString();
                angles(a, b, c);
           }
            else if (B.Text.Trim().Length == 0)
            {
                c = float.Parse(C.Text);
                a = float.Parse(A.Text);
                //c = float.Parse(C.Text);
                b = (float)Math.Sqrt(c * c - a * a);
                B.Text =b.ToString();
                angles(a, b, c);
            }
            else if ((B.Text.Trim().Length == 0 && A.Text.Trim().Length == 0) || (B.Text.Trim().Length == 0 && C.Text.Trim().Length == 0) || (C.Text.Trim().Length == 0 && A.Text.Trim().Length == 0))
            {
                MessageBox.Show("Not enough data!", "", MessageBoxButton.OK);
            }
            else
            {
                clear();
                MessageBox.Show("One box must be empty!", "", MessageBoxButton.OK);
                clear();
            }
            Draw.Children.Clear();
           
            drw();
        }

        private double DTR(double angle)
        {
            return (Math.PI * angle) / 180.0;
        }

        private void angles(float a, float b, float c)
        {
            String c1, c2;
            c1 = RTD(Math.Acos(((float)(b * b + c * c - a * a) / (float)(2 * b * c)))).ToString();
            c2 = RTD(Math.Acos(((float)(-b * b + c * c + a * a) / (float)(2 * a * c)))).ToString();
            C1.Text = c1.Substring(0, 8);
            C2.Text = c2.Substring(0, 8);
            points(a, b, c, Math.Acos(((b * b + c * c - a * a) /(2 * b * c))), Math.Acos(((-b * b + c * c + a * a) / (2 * a * c))));
        }
        private void clear()
        {
            A.Text = "";
            B.Text = "";
            C.Text = "";
            C1.Text = "";
            C2.Text = "";
        }
        public void points(float a, float b, float c, double ang1,double ang2)
        {
            Point[] pnt = new Point[3];

            pnt[0].X = 200;
            pnt[0].Y = 250;



            pnt[1].X = (int)(pnt[0].X - Math.Cos(ang2)*a);
            pnt[1].Y =(int) (pnt[0].Y - Math.Sin(ang2)*a);
      
          pnt[2].X = (int) (pnt[1].X - Math.Cos(ang1)*b);
          pnt[2].Y = (int) (pnt[1].Y - Math.Sin(ang1)*b);

          pontos = pnt;


        }
        private void drw()
        {
            
            
            Line line = new Line();
            Line line1 = new Line();
            Line line2 = new Line();

            line.Stroke = new SolidColorBrush(Colors.White);
            line.StrokeThickness = 3;
            line1.Stroke = new SolidColorBrush(Colors.White);
            line1.StrokeThickness = 3;
            line2.Stroke = new SolidColorBrush(Colors.White);
            line2.StrokeThickness = 3;

            line.X1 = pontos[0].X ;
            line.X2 = pontos[1].X;

            line.Y1 = pontos[0].Y;
            line.Y2 = pontos[1].Y;

            line1.X1 = pontos[1].X;
            line1.X2 = pontos[2].X;
            line1.Y1 = pontos[0].Y; 
            line1.Y2 = pontos[1].Y;

            line2.X1 = pontos[2].X;
            line2.X2 = pontos[1].X;
            line2.Y1 = pontos[0].Y;
            line2.Y2 = pontos[1].Y;

            Draw.Children.Add(line);
            Draw.Children.Add(line1);
            Draw.Children.Add(line2);
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