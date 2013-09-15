using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace TrigMeter
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pyth.xaml?shouldDownload=true", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }
    }
}