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
    public sealed partial class ChooseType : Page
    {
        public ChooseType()
        {
            this.InitializeComponent();
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += OnBackPressed;
        }

        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            // add your own code here to run when Back is pressed
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseMode));
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void BTaddition_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedType = "+";
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseLevel));
        }

        private void BTsoustraction_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedType = "-";
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseLevel));
        }

        private void BTmultiplication_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedType = "*";
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseLevel));
        }

        private void BTdivision_Click(object sender, RoutedEventArgs e)
        {
            SharedInformation.sharedType = "/";
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseLevel));
        }
    }
}
