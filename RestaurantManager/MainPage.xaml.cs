﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ExpeditePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ExpeditePage));
        }

        private void OrderPage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrderPage));
        }
    }
}
