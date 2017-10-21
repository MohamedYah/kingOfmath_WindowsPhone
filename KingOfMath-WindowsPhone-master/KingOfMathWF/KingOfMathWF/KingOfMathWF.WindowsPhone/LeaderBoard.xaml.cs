using Parse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
    public sealed partial class LeaderBoard : Page
    {
        List<Player> lstjoueur = new List<Player>();
        public LeaderBoard()
        {
            this.InitializeComponent();
            TFConnection.Visibility = Visibility.Collapsed;
            HardwareButtons.BackPressed += OnBackPressed;
            dataGet();
            
            //lst.DataContext = lstjoueur;
            
        }
        private async void dataGet()
        {
            //var query = ParseObject.GetQuery("TestObject").OrderByDescending("score");
            try
            {
                var query = ParseObject.GetQuery("TestObject")
                   .OrderByDescending("score");
                IEnumerable<ParseObject> results = await query.FindAsync();
                String Sscore = ""; String Sname = "";String Scolor = "";int Srank = 0;
                foreach (ParseObject PO in results)
                {
                    Srank++;
                    Scolor = "ms-appx:/Assets/Quizz/backgrouditem.png";
                    Sscore = ""+PO.Get<int>("score");
                    Sname = PO.Get<String>("name");
                    if (PO.ObjectId == IsolatedStorageHelper.GetObject<String>("1111"))
                    {
                        Scolor= "ms-appx:/Assets/backgrouditem2.png";
                    }

                    System.Diagnostics.Debug.WriteLine(Sname + Sscore);

                    lstjoueur.Add(new Player() { name = Sname, score = Sscore ,color=Scolor,rank=Srank});
                }

                lst.DataContext = lstjoueur;
            }
            catch (WebException ex)
            {

                TFConnection.Visibility = Visibility.Visible;
            }

            
        }


        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            // add your own code here to run when Back is pressed
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(MainMenu));
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
