using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Phone.UI.Input;
using Parse;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media.Imaging;
using System.Net;
using FaceBookWp8._1.Helpers;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace KingOfMathWF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        String id,AcessToken;
        FaceBookHelper ObjFBHelper = new FaceBookHelper();
        
        public MainMenu()
        {

            this.InitializeComponent();

            id = IsolatedStorageHelper.GetObject<String>("1");
            AcessToken = IsolatedStorageHelper.GetObject<String>("2");
           
            if(IsolatedStorageHelper.GetObject<String>("1")!=null)
            {
                GetUserProfilePicture(id);
            }
           else if (IsolatedStorageHelper.GetObject<String>("image") == "1")
            {
                BTimage.DataContext = "Assets/Player/player1.png";
            }
            else if (IsolatedStorageHelper.GetObject<String>("image") == "2")
            {

                BTimage.DataContext = "Assets/Player/player2.png";
            }
            else if (IsolatedStorageHelper.GetObject<String>("image") == "3")
            {

                BTimage.DataContext = "Assets/Player/player3.png";
            }
            else if (IsolatedStorageHelper.GetObject<String>("image") == "4")
            {

                BTimage.DataContext = "Assets/Player/player4.png";
            }
            else
            {

                BTimage.DataContext = "Assets/Player/player0.png";
            }
            HardwareButtons.BackPressed += OnBackPressed;
            if (IsolatedStorageHelper.GetObject<String>("audio") == "play")
            {

                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/SoundOn.png"));
                brush.Stretch = Stretch.Uniform;
                BTsound.Background = brush;
            }
            else
            {

                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/SoundOff.png"));
                brush.Stretch = Stretch.Uniform;
                BTsound.Background = brush;
            }

            TFName.Text = "Name : " + SharedInformation.sharedPName;

            int i; int totalScore = 0;
            for (i = 1; i < 11; i++)
            {
                totalScore += IsolatedStorageHelper.GetObject<int>("addition" + i);
                totalScore += IsolatedStorageHelper.GetObject<int>("soustraction" + i);
                totalScore += IsolatedStorageHelper.GetObject<int>("multiplication" + i);
                totalScore += IsolatedStorageHelper.GetObject<int>("division" + i);
            }
            totalScore += IsolatedStorageHelper.GetObject<int>("Basics");
            totalScore += IsolatedStorageHelper.GetObject<int>("Linearty");
            totalScore += IsolatedStorageHelper.GetObject<int>("Quadratica");
            totalScore += IsolatedStorageHelper.GetObject<int>("Multiplication");
            totalScore += IsolatedStorageHelper.GetObject<int>("Power Ranger");
            totalScore += IsolatedStorageHelper.GetObject<int>("Division");
            totalScore += IsolatedStorageHelper.GetObject<int>("The Mentalist");

            TFScore.Text = "Score : " + totalScore;
            dataUpdate(totalScore);
        }
        private void GetUserProfilePicture(string UserID)
        {
            string profilePictureUrl = string.Format("https://graph.facebook.com/{0}/picture?type={1}&access_token={2}", UserID, "square", AcessToken);
            BTimage.Source = new BitmapImage(new Uri(profilePictureUrl));
        }
        private  void dataUpdate(int score)
        {
            var testObject = new ParseObject("TestObject");
            testObject.ObjectId = IsolatedStorageHelper.GetObject<String>("1111"); try
            {
                 testObject.SaveAsync();
                testObject["name"] = SharedInformation.sharedPName;
                testObject["score"] = score; testObject["idfacebook"] = "0"; testObject["idposition"] = IsolatedStorageHelper.GetObject<String>("image");

                 testObject.SaveAsync();
            }
            catch (WebException ex)
            {
                // generic error handling
            }

        }

        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            // add your own code here to run when Back is pressed
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(MainPage));
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(ChooseMode));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            HardwareButtons.BackPressed -= OnBackPressed;
            Frame.Navigate(typeof(LeaderBoard));
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageHelper.GetObject<String>("audio") == "play")
            {

                BackgroundMediaPlayer.Current.Pause(); BackgroundMediaPlayer.Current.Position = TimeSpan.FromSeconds(0);
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/SoundOff.png"));
                brush.Stretch = Stretch.Uniform;
                BTsound.Background = brush;

                IsolatedStorageHelper.SaveObject("audio", "stop");
            }
            else
            {

                BackgroundMediaPlayer.Current.SetUriSource(new Uri("ms-appx:///Assets/Audio/song.mp3"));
                BackgroundMediaPlayer.Current.Play();
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/SoundOn.png"));
                brush.Stretch = Stretch.Uniform;
                BTsound.Background = brush;

                IsolatedStorageHelper.SaveObject("audio", "play");
            }
        }
    }
}
