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
    public sealed partial class ChooseQuizz : Page
    {
        List<Quizz> lstQuizz = new List<Quizz>();
        String score = "No games played yet";int scores = 0;
        public ChooseQuizz()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += OnBackPressed;
            scores =IsolatedStorageHelper.GetObject<int>("Basics");
            if(scores != 0)
            {
                score = "    " + scores;
            }
            lstQuizz.Add(new Quizz() { name = "Basics", score = score, img = "Assets/Quizz/quizzitem1.png" });



            score = "No games played yet";
            scores = IsolatedStorageHelper.GetObject<int>("Linearty");
            if (scores != 0)
            {
                score = "    " + scores;
            }
            lstQuizz.Add(new Quizz() { name = "Linearty", score = score, img = "Assets/Quizz/quizzitem2.png" });



            score = "No games played yet";
            scores = IsolatedStorageHelper.GetObject<int>("Quadratica");
            if (scores != 0)
            {
                score = "    " + scores;
            }
            lstQuizz.Add(new Quizz() { name = "Quadratica", score = score, img = "Assets/Quizz/quizzitem3.png" });
            score = "No games played yet";
            scores = IsolatedStorageHelper.GetObject<int>("Multiplication");
            if (scores != 0)
            {
                score = "    " + scores;
            }
            lstQuizz.Add(new Quizz() { name = "Multiplication", score = score, img = "Assets/Quizz/quizzitem4.png" });
            score = "No games played yet";
            scores = IsolatedStorageHelper.GetObject<int>("Power Ranger");
            if (scores != 0)
            {
                score = "    " + scores;
            }
            lstQuizz.Add(new Quizz() { name = "Power Ranger", score = score, img = "Assets/Quizz/quizzitem5.png" });
            score = "No games played yet";
            scores = IsolatedStorageHelper.GetObject<int>("Division");
            if (scores != 0)
            {
                score = "    " + scores;
            }
            lstQuizz.Add(new Quizz() { name = "Division", score = score, img = "Assets/Quizz/quizzitem6.png" });
            score = "No games played yet";
            scores = IsolatedStorageHelper.GetObject<int>("The Mentalist");
            if (scores != 0)
            {
                score = "    " + scores;
            }
            lstQuizz.Add(new Quizz() { name = "The Mentalist", score = score, img = "Assets/Quizz/quizzitem7.png" });


            lst.DataContext = lstQuizz;
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
        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SharedInformation.sharedType = lstQuizz[lst.SelectedIndex].name;
            Frame.Navigate(typeof(GamePage));
        }
    }
}
