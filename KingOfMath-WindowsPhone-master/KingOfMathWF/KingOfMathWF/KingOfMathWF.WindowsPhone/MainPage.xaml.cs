using Parse;
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
using Windows.Media.Playback;

using Windows.ApplicationModel.Background;
using System.Net;
using FaceBookWp8._1.Helpers;
using Windows.ApplicationModel.Activation;
using Windows.UI.Popups;
using Windows.Security.Authentication.Web;
using Windows.UI.Xaml.Media.Imaging;
using System.Diagnostics;
using Facebook;
using Windows.Graphics.Display;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KingOfMathWF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, IWebAuthenticationBrokerContinuable
    {
        readonly Uri _loginUrl;
        string FBName;
        string id;
        public MainPage()
        {
            this.InitializeComponent();
            var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;

            Debug.WriteLine("The current resolution is {0}x{1}", Window.Current.Bounds.Width * scaleFactor, Window.Current.Bounds.Height * scaleFactor);

            button2.DataContext = 1;
            button2_Copy.DataContext = 1;
            button2_Copy1.DataContext = 1;
            button2_Copy2.DataContext = 1;
            if(SharedInformation.sharedPName != null)
            {
                TFname.Text = SharedInformation.sharedPName;
            }
            else
            {
                TFname.Text = "Player";
            }


            if (IsolatedStorageHelper.GetObject<String>("image") == "1")
            {
                button2.DataContext = 1;
                button2_Copy.DataContext = 0.7;
                button2_Copy1.DataContext = 0.7;
                button2_Copy2.DataContext = 0.7;
            }
            else if (IsolatedStorageHelper.GetObject<String>("image") == "2")
            {

                button2_Copy.DataContext = 1;
                button2.DataContext = 0.7;
                button2_Copy1.DataContext = 0.7;
                button2_Copy2.DataContext = 0.7;
            }
            else if (IsolatedStorageHelper.GetObject<String>("image") == "3")
            {
                button2_Copy2.DataContext = 1;
                button2.DataContext = 0.7;
                button2_Copy.DataContext = 0.7;
                button2_Copy1.DataContext = 0.7;
            }
            else if (IsolatedStorageHelper.GetObject<String>("image") == "4")
            {

                button2_Copy1.DataContext = 1;
                button2.DataContext = 0.7;
                button2_Copy.DataContext = 0.7;
                button2_Copy2.DataContext = 0.7;
            }
            else
            {
                button2_Copy1.DataContext = 1;
                button2.DataContext = 1;
                button2_Copy.DataContext = 1;
                button2_Copy2.DataContext = 1;
            }






            if (IsolatedStorageHelper.GetObject<String>("audio") == null)
            {
                //BackgroundMediaPlayer.Current.SetUriSource(new Uri("ms-appx:///Assests/Audio/song.mp3"));
                //BackgroundMediaPlayer.Current.Play();
                IsolatedStorageHelper.SaveObject("audio", "play");
                //BackgroundMediaPlayer.Current.Play();
                //BackgroundMediaPlayer.Current.Pause(); BackgroundMediaPlayer.Current.Position = TimeSpan.FromSeconds(0);
            }
            if (IsolatedStorageHelper.GetObject<String>("audio") == "play")
            {

                BackgroundMediaPlayer.Current.SetUriSource(new Uri("ms-appx:///Assets/Audio/song.mp3"));
                BackgroundMediaPlayer.Current.Play();
            }


            this.NavigationCacheMode = NavigationCacheMode.Required;
            if (IsolatedStorageHelper.GetObject<String>("1001") != null)
            {
                SharedInformation.sharedPName = IsolatedStorageHelper.GetObject<String>("1001");
                TFname.Text = SharedInformation.sharedPName;
                //Frame.Navigate(typeof(MainMenu));

            }
            else
            {
                String firstusetest = "";
                firstusetest = IsolatedStorageHelper.GetObject<String>("1000");
                if (firstusetest == null)
                {
                    dataInit();
                    for (int i = 1; i < 11; i++)
                    {
                        IsolatedStorageHelper.SaveObject("addition" + i, 0);
                        IsolatedStorageHelper.SaveObject("soustraction" + i, 0);
                        IsolatedStorageHelper.SaveObject("multiplication" + i, 0);
                        IsolatedStorageHelper.SaveObject("division" + i, 0);
                    }
                    IsolatedStorageHelper.SaveObject("Basics", 0);
                    IsolatedStorageHelper.SaveObject("Linearty", 0);
                    IsolatedStorageHelper.SaveObject("Quadratica", 0);
                    IsolatedStorageHelper.SaveObject("Multiplication", 0);
                    IsolatedStorageHelper.SaveObject("Power Ranger", 0);
                    IsolatedStorageHelper.SaveObject("Division", 0);
                    IsolatedStorageHelper.SaveObject("The Mentalist", 0);

                    IsolatedStorageHelper.SaveObject("death", 0);
                    IsolatedStorageHelper.SaveObject("1000", "OPPS");
                }
            }

        }

        public sealed class AudioPlayer : IBackgroundTask
        {
            private BackgroundTaskDeferral _deferral;
            public void Run(IBackgroundTaskInstance taskInstance)
            {
                _deferral = taskInstance.GetDeferral();
                taskInstance.Canceled += TaskInstance_Canceled;
            }
            private void TaskInstance_Canceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
            {
                _deferral.Complete();
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        private async void dataInit()
        {
            var testObject = new ParseObject("TestObject");
            testObject["name"] = "Player";
            testObject["score"] = 0; testObject["idfacebook"] = "0"; testObject["idposition"] = "0";
            try
            {
                await testObject.SaveAsync();
                System.Diagnostics.Debug.WriteLine(testObject.ObjectId);
                IsolatedStorageHelper.SaveObject("1111", testObject.ObjectId);
            }
            catch (WebException ex)
            {
                // generic error handling
            }
            //TFname.Text = testObject.ObjectId;
        }
        private  void button_Click(object sender, RoutedEventArgs e)
        {
            

            SharedInformation.sharedPName = TFname.Text;
            Frame.Navigate(typeof(MainMenu));
            IsolatedStorageHelper.SaveObject("1001", TFname.Text);
            

                

        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            button2.DataContext = 1;
            button2_Copy.DataContext = 0.7;
            button2_Copy1.DataContext = 0.7;
            button2_Copy2.DataContext = 0.7;
            IsolatedStorageHelper.SaveObject("image", "1");

        }

        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {

            button2_Copy.DataContext = 1;
            IsolatedStorageHelper.SaveObject("image", "2");
            button2.DataContext = 0.7;
            button2_Copy1.DataContext = 0.7;
            button2_Copy2.DataContext = 0.7;
        }

        private void button2_Copy2_Click(object sender, RoutedEventArgs e)
        {
            button2_Copy2.DataContext = 1;

            IsolatedStorageHelper.SaveObject("image", "3");
            button2.DataContext = 0.7;
            button2_Copy.DataContext = 0.7;
            button2_Copy1.DataContext = 0.7;
        }

        private void button2_Copy1_Click(object sender, RoutedEventArgs e)
        {

            button2_Copy1.DataContext = 1;
            button2.DataContext = 0.7;
            button2_Copy.DataContext = 0.7;
            button2_Copy2.DataContext = 0.7;
            IsolatedStorageHelper.SaveObject("image", "4");
        }
        /*facebook*/
        FaceBookHelper ObjFBHelper = new FaceBookHelper();
        private void BtnFaceBookLogin_Click(object sender, RoutedEventArgs e)
        {
            ObjFBHelper.LoginAndContinue();
           
        }
        FacebookClient fbclient = new FacebookClient();
        public async void ContinueWithWebAuthenticationBroker(WebAuthenticationBrokerContinuationEventArgs args)
        {
            ObjFBHelper.ContinueAuthentication(args);
            if (ObjFBHelper.AccessToken != null)
            {
                IsolatedStorageHelper.SaveObject<String>("2", ObjFBHelper.AccessToken);

                fbclient = new Facebook.FacebookClient(ObjFBHelper.AccessToken);
                //Fetch facebook UserProfile:
                dynamic result = await fbclient.GetTaskAsync("me");
                 id = result.id;
                string email = result.email;
                FBName = result.name;
                Debug.WriteLine("sssssssss");
                Debug.WriteLine(id);
                Debug.WriteLine(FBName);
                //Format UserProfile:
                GetUserProfilePicture(id);
               
                BtnLogin.Visibility = Visibility.Collapsed;
                BtnLogout.Visibility = Visibility.Visible;


                TFname.Text = FBName;
              
             IsolatedStorageHelper.SaveObject("1", id);
            }
            else
            {
                String message = "No Internet Connection";
                var dialog = new MessageDialog(message);
                await dialog.ShowAsync();
            }

        }
        private void GetUserProfilePicture(string UserID)
        {
            string profilePictureUrl = string.Format("https://graph.facebook.com/{0}/picture?type={1}&access_token={2}", UserID, "square", ObjFBHelper.AccessToken);
          
        }

        private async void BtnFaceBookPost_Click(object sender, RoutedEventArgs e)
        {
            var postParams = new
            {
                name = "Facebook Post Testing from App.",
                caption = "WindowsPhone 8.1 FaceBook Integration.",
                link = "http://bsubramanyamraju.blogspot.in",
             
                picture = "http://facebooksdk.net/assets/img/logo75x75.png"
            };
            try
            {
                dynamic fbPostTaskResult = await fbclient.PostTaskAsync("/me/feed", postParams);
                var responseresult = (IDictionary<string, object>)fbPostTaskResult;
                MessageDialog SuccessMsg = new MessageDialog("Message posted sucessfully on facebook wall");
                await SuccessMsg.ShowAsync();

                
            }
            catch (Exception ex)
            {
                //MessageDialog ErrMsg = new MessageDialog("Error Ocuured!");

            }
        }
        Uri _logoutUrl;
        private async void BtnFaceBookLogout_Click(object sender, RoutedEventArgs e)
        {
            _logoutUrl = fbclient.GetLogoutUrl(new
            {
                next = "https://www.facebook.com/connect/login_success.html",
                access_token = ObjFBHelper.AccessToken
            });
            WebAuthenticationBroker.AuthenticateAndContinue(_logoutUrl);
            BtnLogin.Visibility = Visibility.Visible;
            BtnLogout.Visibility = Visibility.Collapsed;
        }


    }
}
