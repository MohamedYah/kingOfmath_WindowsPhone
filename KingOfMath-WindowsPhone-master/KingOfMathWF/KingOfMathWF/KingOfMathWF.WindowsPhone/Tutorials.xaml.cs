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
    public sealed partial class Tutorials : Page
    {
        int choixTuto = 0;
        int tutoIndice = 0;
        public Tutorials()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += OnBackPressed;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            // add your own code here to run when Back is pressed
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseMode));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (choixTuto == 1)
            {
                if (tutoIndice == 1)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutoaddition2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutoaddition3.png";
                }
                else if (tutoIndice == 3)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutoaddition4.png";
                }
            }


            if (choixTuto == 2)
            {
                if (tutoIndice == 1)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutosoustraction2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutosoustraction3.png";
                }
            }
            if (choixTuto == 3)
            {
                if (tutoIndice == 1)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutomultiplication2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutomultiplication3.png";
                }
                else if (tutoIndice == 3)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutomultiplication4.png";
                }
                else if (tutoIndice == 4)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutomultiplication5.png";
                }
            }


            if (choixTuto == 4)
            {
                if (tutoIndice == 1)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutodivision2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice++;
                    image.DataContext = "Assets/Tutorial/tutodivision3.png";
                }
            }

        }

        private void Previous(object sender, RoutedEventArgs e)
        {
            if (choixTuto == 1)
            {
                if (tutoIndice == 4)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutoaddition3.png";
                }
                else if (tutoIndice == 3)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutoaddition2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutoaddition1.png";
                }
            }


            if (choixTuto == 2)
            {
                if (tutoIndice == 3)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutosoustraction2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutosoustraction1.png";
                }
            }
            if (choixTuto == 3)
            {
                if (tutoIndice == 5)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutomultiplication4.png";
                }
                else if (tutoIndice == 4)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutomultiplication3.png";
                }
                else if (tutoIndice == 3)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutomultiplication2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutomultiplication1.png";
                }
            }


            if (choixTuto == 4)
            {
                if (tutoIndice == 3)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutodivision2.png";
                }
                else if (tutoIndice == 2)
                {
                    tutoIndice--;
                    image.DataContext = "Assets/Tutorial/tutodivision1.png";
                }
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

            image.DataContext = "Assets/Tutorial/tutoaddition1.png";
            choixTuto = 1;
            tutoIndice = 1;
        }

        private void sous_Click(object sender, RoutedEventArgs e)
        {

            image.DataContext = "Assets/Tutorial/tutosoustraction1.png";
            choixTuto = 2;
            tutoIndice = 1;
        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            image.DataContext = "Assets/Tutorial/tutomultiplication1.png";
            choixTuto = 3;
            tutoIndice = 1;
        }

        private void divi_Click(object sender, RoutedEventArgs e)
        {

            image.DataContext = "Assets/Tutorial/tutodivision1.png";
            choixTuto = 4;
            tutoIndice = 1;
        }
    }
}
