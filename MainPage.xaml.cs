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
        private void About1(object sender, EventArgs eventArgs)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pyth.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Areas.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Solve.xaml", UriKind.Relative));
        }

        private void Volum_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Volume.xaml", UriKind.Relative));
        }
    }
}