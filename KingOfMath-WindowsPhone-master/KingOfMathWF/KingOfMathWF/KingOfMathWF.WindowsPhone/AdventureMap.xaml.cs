using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace KingOfMathWF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdventureMap : Page
    {


        List<String> lstBT = new List<String>();
        public AdventureMap()
        {
            this.InitializeComponent();
            var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;

            Debug.WriteLine("The current resolution is {0}x{1}", Window.Current.Bounds.Width * scaleFactor, Window.Current.Bounds.Height * scaleFactor);
            int x = 400;int y = 0;
            if(Window.Current.Bounds.Width * scaleFactor> 1000)
            {
                x = 450;
                if(Window.Current.Bounds.Width * scaleFactor < 1080)
                {
                    x = 490;
                }
            }
            listView.DataContext = x;
            grid1.DataContext = x;
            grid2.DataContext = x;
            grid3.DataContext = x;
            grid4.DataContext = x;


            HardwareButtons.BackPressed += OnBackPressed;
            SharedInformation.sharedMode = "adventure";
            button1.DataContext = "Assets/AdventureBt/levellevel1.png";
            lstBT.Add("Assets/AdventureBt/levellevel1.png"); int i = 1;



                button2.DataContext = "Assets/AdventureBt/level2.png";
                button3.DataContext = "Assets/AdventureBt/level3.png";
                button4.DataContext = "Assets/AdventureBt/level4.png";
                button5.DataContext = "Assets/AdventureBt/level5.png"; 
                button6.DataContext = "Assets/AdventureBt/level6.png";
                button7.DataContext = "Assets/AdventureBt/level7.png";
                button8.DataContext = "Assets/AdventureBt/level8.png";
                button9.DataContext = "Assets/AdventureBt/level9.png";
                button10.DataContext = "Assets/AdventureBt/level10.png"; 
                button11.DataContext = "Assets/AdventureBt/level11.png";
                button12.DataContext = "Assets/AdventureBt/level12.png";
                button13.DataContext = "Assets/AdventureBt/level13.png"; 
                button14.DataContext = "Assets/AdventureBt/level14.png";
                button15.DataContext = "Assets/AdventureBt/level15.png"; 
                button16.DataContext = "Assets/AdventureBt/level16.png";
                button17.DataContext = "Assets/AdventureBt/level17.png"; 
                button18.DataContext = "Assets/AdventureBt/level18.png";
                button19.DataContext = "Assets/AdventureBt/level19.png";
                button20.DataContext = "Assets/AdventureBt/level20.png";
                button21.DataContext = "Assets/AdventureBt/level21.png";
                button22.DataContext = "Assets/AdventureBt/level22.png";
                button23.DataContext = "Assets/AdventureBt/level23.png";
                button24.DataContext = "Assets/AdventureBt/level24.png";
                button25.DataContext = "Assets/AdventureBt/level25.png";
                button26.DataContext = "Assets/AdventureBt/level26.png"; 
                button27.DataContext = "Assets/AdventureBt/level27.png"; 
                button28.DataContext = "Assets/AdventureBt/level28.png";
                button29.DataContext = "Assets/AdventureBt/level29.png";
                button30.DataContext = "Assets/AdventureBt/level30.png";
                button31.DataContext = "Assets/AdventureBt/level31.png";
                button32.DataContext = "Assets/AdventureBt/level32.png";
                button33.DataContext = "Assets/AdventureBt/level33.png";
                button34.DataContext = "Assets/AdventureBt/level34.png";
                button35.DataContext = "Assets/AdventureBt/level35.png";
                button36.DataContext = "Assets/AdventureBt/level36.png";
                button37.DataContext = "Assets/AdventureBt/level37.png";
                button38.DataContext = "Assets/AdventureBt/level38.png";
            





















            if (IsolatedStorageHelper.GetObject<int>("addition1") != 0)
            {
                button2.DataContext = "Assets/AdventureBt/levellevel2.png";
                lstBT.Add("Assets/AdventureBt/levellevel2.png");i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition2") != 0)
            {
                button3.DataContext = "Assets/AdventureBt/levellevel3.png";
                lstBT.Add("Assets/AdventureBt/levellevel3.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition3") != 0)
            {
                button4.DataContext = "Assets/AdventureBt/levellevel4.png";
                lstBT.Add("Assets/AdventureBt/levellevel4.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition4") != 0)
            {
                button5.DataContext = "Assets/AdventureBt/levellevel5.png";
                lstBT.Add("Assets/AdventureBt/levellevel5.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition5") != 0)
            {
                button6.DataContext = "Assets/AdventureBt/levellevel6.png";
                lstBT.Add("Assets/AdventureBt/levellevel6.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition6") != 0)
            {
                button7.DataContext = "Assets/AdventureBt/levellevel7.png";
                lstBT.Add("Assets/AdventureBt/levellevel7.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition7") != 0)
            {
                button8.DataContext = "Assets/AdventureBt/levellevel8.png";
                lstBT.Add("Assets/AdventureBt/levellevel8.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition8") != 0)
            {
                button9.DataContext = "Assets/AdventureBt/levellevel9.png";
                lstBT.Add("Assets/AdventureBt/levellevel9.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition9") != 0)
            {
                button10.DataContext = "Assets/AdventureBt/levellevel10.png";
                lstBT.Add("Assets/AdventureBt/levellevel10.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("addition10") != 0)
            {
                button11.DataContext = "Assets/AdventureBt/levellevel11.png";
                lstBT.Add("Assets/AdventureBt/levellevel11.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction1") != 0)
            {
                button12.DataContext = "Assets/AdventureBt/levellevel12.png";
                lstBT.Add("Assets/AdventureBt/levellevel12.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction2") != 0)
            {
                button13.DataContext = "Assets/AdventureBt/levellevel13.png";
                lstBT.Add("Assets/AdventureBt/levellevel13.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction3") != 0)
            {
                button14.DataContext = "Assets/AdventureBt/levellevel14.png";
                lstBT.Add("Assets/AdventureBt/levellevel14.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction4") != 0)
            {
                button15.DataContext = "Assets/AdventureBt/levellevel15.png";
                lstBT.Add("Assets/AdventureBt/levellevel15.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction5") != 0)
            {
                button16.DataContext = "Assets/AdventureBt/levellevel16.png";
                lstBT.Add("Assets/AdventureBt/levellevel16.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction6") != 0)
            {
                button17.DataContext = "Assets/AdventureBt/levellevel17.png";
                lstBT.Add("Assets/AdventureBt/levellevel17.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction7") != 0)
            {
                button18.DataContext = "Assets/AdventureBt/levellevel18.png";
                lstBT.Add("Assets/AdventureBt/levellevel18.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction8") != 0)
            {
                button19.DataContext = "Assets/AdventureBt/levellevel19.png";
                lstBT.Add("Assets/AdventureBt/levellevel19.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction9") != 0)
            {
                button20.DataContext = "Assets/AdventureBt/levellevel20.png";
                lstBT.Add("Assets/AdventureBt/levellevel20.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("soustraction10") != 0)
            {
                button21.DataContext = "Assets/AdventureBt/levellevel21.png";
                lstBT.Add("Assets/AdventureBt/levellevel21.png"); i++;
            }

            if (IsolatedStorageHelper.GetObject<int>("multiplication1") != 0)
            {
                button22.DataContext = "Assets/AdventureBt/levellevel22.png";
                lstBT.Add("Assets/AdventureBt/levellevel22.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication2") != 0)
            {
                button23.DataContext = "Assets/AdventureBt/levellevel23.png";
                lstBT.Add("Assets/AdventureBt/levellevel23.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication3") != 0)
            {
                button24.DataContext = "Assets/AdventureBt/levellevel24.png";
                lstBT.Add("Assets/AdventureBt/levellevel24.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication4") != 0)
            {
                button25.DataContext = "Assets/AdventureBt/levellevel25.png";
                lstBT.Add("Assets/AdventureBt/levellevel25.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication5") != 0)
            {
                button26.DataContext = "Assets/AdventureBt/levellevel26.png";
                lstBT.Add("Assets/AdventureBt/levellevel26.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication6") != 0)
            {
                button27.DataContext = "Assets/AdventureBt/levellevel27.png";
                lstBT.Add("Assets/AdventureBt/levellevel27.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication7") != 0)
            {
                button28.DataContext = "Assets/AdventureBt/levellevel28.png";
                lstBT.Add("Assets/AdventureBt/levellevel28.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication8") != 0)
            {
                button29.DataContext = "Assets/AdventureBt/levellevel29.png";
                lstBT.Add("Assets/AdventureBt/levellevel29.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication9") != 0)
            {
                button30.DataContext = "Assets/AdventureBt/levellevel30.png";
                lstBT.Add("Assets/AdventureBt/levellevel30.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("multiplication10") != 0)
            {
                button31.DataContext = "Assets/AdventureBt/levellevel31.png";

                lstBT.Add("Assets/AdventureBt/levellevel31.png"); i++;
            }


            if (IsolatedStorageHelper.GetObject<int>("division1") != 0)
            {
                button32.DataContext = "Assets/AdventureBt/levellevel32.png";
                lstBT.Add("Assets/AdventureBt/levellevel32.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("division2") != 0)
            {
                button33.DataContext = "Assets/AdventureBt/levellevel33.png";
                lstBT.Add("Assets/AdventureBt/levellevel33.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("division3") != 0)
            {
                button34.DataContext = "Assets/AdventureBt/levellevel34.png";
                lstBT.Add("Assets/AdventureBt/levellevel34.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("division4") != 0)
            {
                button35.DataContext = "Assets/AdventureBt/levellevel35.png";
                lstBT.Add("Assets/AdventureBt/levellevel35.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("division5") != 0)
            {
                button36.DataContext = "Assets/AdventureBt/levellevel36.png";
                lstBT.Add("Assets/AdventureBt/levellevel36.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("division6") != 0)
            {
                button37.DataContext = "Assets/AdventureBt/levellevel37.png";
                lstBT.Add("Assets/AdventureBt/levellevel37.png"); i++;
            }
            if (IsolatedStorageHelper.GetObject<int>("division7") != 0)
            {
                button38.DataContext = "Assets/AdventureBt/levellevel38.png";
                lstBT.Add("Assets/AdventureBt/levellevel38.png"); i++;
            }
            for (int coun=i; coun < 37; coun++)
            {
                lstBT.Add("Assets/AdventureBt/level"+(coun+1)+".png");
            }
            //listView.DataContext = lstBT;

            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (sender == button1)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 1;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button2 && IsolatedStorageHelper.GetObject<int>("addition1") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 2;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button3 && IsolatedStorageHelper.GetObject<int>("addition2") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 3;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button4 && IsolatedStorageHelper.GetObject<int>("addition3") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 4;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button5 && IsolatedStorageHelper.GetObject<int>("addition4") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 5;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button6 && IsolatedStorageHelper.GetObject<int>("addition5") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 6;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button7 && IsolatedStorageHelper.GetObject<int>("addition6") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 7;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button8 && IsolatedStorageHelper.GetObject<int>("addition7") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 8;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button9 && IsolatedStorageHelper.GetObject<int>("addition8") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 9;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button10 && IsolatedStorageHelper.GetObject<int>("addition9") != 0)
            {
                SharedInformation.sharedType = "+"; SharedInformation.sharedPLevel = 10;
                Frame.Navigate(typeof(GamePage));
            }


            if (sender == button11 && IsolatedStorageHelper.GetObject<int>("addition10") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 1;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button12 && IsolatedStorageHelper.GetObject<int>("soustraction1") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 2;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button13 && IsolatedStorageHelper.GetObject<int>("soustraction2") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 3;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button14 && IsolatedStorageHelper.GetObject<int>("soustraction3") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 4;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button15 && IsolatedStorageHelper.GetObject<int>("soustraction4") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 5;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button16 && IsolatedStorageHelper.GetObject<int>("soustraction5") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 6;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button17 && IsolatedStorageHelper.GetObject<int>("soustraction6") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 7;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button18 && IsolatedStorageHelper.GetObject<int>("soustraction7") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 8;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button19 && IsolatedStorageHelper.GetObject<int>("soustraction8") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 9;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button20 && IsolatedStorageHelper.GetObject<int>("soustraction9") != 0)
            {
                SharedInformation.sharedType = "-"; SharedInformation.sharedPLevel = 10;
                Frame.Navigate(typeof(GamePage));
            }


            if (sender == button21 && IsolatedStorageHelper.GetObject<int>("soustraction10") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 1;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button22 && IsolatedStorageHelper.GetObject<int>("multiplication1") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 2;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button23 && IsolatedStorageHelper.GetObject<int>("multiplication2") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 3;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button24 && IsolatedStorageHelper.GetObject<int>("multiplication3") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 4;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button25 && IsolatedStorageHelper.GetObject<int>("multiplication4") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 5;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button26 && IsolatedStorageHelper.GetObject<int>("multiplication5") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 6;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button27 && IsolatedStorageHelper.GetObject<int>("multiplication6") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 7;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button28 && IsolatedStorageHelper.GetObject<int>("multiplication7") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 8;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button29 && IsolatedStorageHelper.GetObject<int>("multiplication8") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 9;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button30 && IsolatedStorageHelper.GetObject<int>("multiplication9") != 0)
            {
                SharedInformation.sharedType = "*"; SharedInformation.sharedPLevel = 10;
                Frame.Navigate(typeof(GamePage));
            }



            if (sender == button31 && IsolatedStorageHelper.GetObject<int>("multiplication10") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 1;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button32 && IsolatedStorageHelper.GetObject<int>("division1") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 2;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button33 && IsolatedStorageHelper.GetObject<int>("division2") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 3;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button34 && IsolatedStorageHelper.GetObject<int>("division3") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 4;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button35 && IsolatedStorageHelper.GetObject<int>("division4") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 5;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button36 && IsolatedStorageHelper.GetObject<int>("division5") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 6;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button37 && IsolatedStorageHelper.GetObject<int>("division6") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 7;
                Frame.Navigate(typeof(GamePage));
            }
            if (sender == button38 && IsolatedStorageHelper.GetObject<int>("division7") != 0)
            {
                SharedInformation.sharedType = "/"; SharedInformation.sharedPLevel = 8;
                Frame.Navigate(typeof(GamePage));
            }
        }
        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            // add your own code here to run when Back is pressed
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseMode));
        }
    }
}
