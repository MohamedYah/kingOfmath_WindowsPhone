using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace KingOfMathWF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChooseLevel : Page
    {
        public ChooseLevel()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += OnBackPressed;
            String operation="";
            if (SharedInformation.sharedType == "+")
            {
                operation = "addition";
            }
            if (SharedInformation.sharedType == "-")
            {
                operation = "soustraction";
            }
            if (SharedInformation.sharedType == "*")
            {
                operation = "multiplication";
            }
            if (SharedInformation.sharedType == "/")
            {
                operation = "division";
            }

            if (IsolatedStorageHelper.GetObject<int>(operation + "1") != 0)
            {
                BTlvl1.Content = BTlvl1.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "1");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "2") != 0)
            {
                BTlvl2.Content = BTlvl2.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "2");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "3") != 0)
            {
                BTlvl3.Content = BTlvl3.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "3");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "4") != 0)
            {
                BTlvl4.Content = BTlvl4.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "4");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "5") != 0)
            {
                BTlvl5.Content = BTlvl5.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "5");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "6") != 0)
            {
                BTlvl6.Content = BTlvl6.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "6");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "7") != 0)
            {
                BTlvl7.Content = BTlvl7.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "7");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "8") != 0)
            {
                BTlvl8.Content = BTlvl8.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "8");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "9") != 0)
            {
                BTlvl9.Content = BTlvl9.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "9");
            }
            if (IsolatedStorageHelper.GetObject<int>(operation + "10") != 0)
            {
                BTlvl10.Content = BTlvl10.Content + " : " + IsolatedStorageHelper.GetObject<int>(operation + "10");
            }
            

        }

        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            // add your own code here to run when Back is pressed
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseType));
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void BTlvl1_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 1;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl2_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 2;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl3_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 3;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl4_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 4;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl5_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 5;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl6_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 6;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl7_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 7;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl8_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 8;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl9_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 9;
            Frame.Navigate(typeof(GamePage));
        }

        private void BTlvl10_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedPLevel = 10;
            Frame.Navigate(typeof(GamePage));
        }
    }
}
