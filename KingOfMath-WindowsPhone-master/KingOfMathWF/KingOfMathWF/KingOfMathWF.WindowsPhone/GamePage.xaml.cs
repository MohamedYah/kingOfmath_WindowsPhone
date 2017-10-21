using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Phone.Devices.Notification;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace KingOfMathWF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        int solution = 0; int i = 0;int j = 0; int lifes = 3;int nb1 = 0;int nb2 = 0;String op = "";int deff = 1;int deffQuizz = 0;
        String modes = ""; int time = 100;
        int score = 5000;
        int RPVrais=0;int RPFaux = 0;
        Random rnd = new Random();
        String operation = "";
        String alive ="Assets/life2.png"; String dead = "Assets/life1.png";
        VibrationDevice testVibrationDevice = VibrationDevice.GetDefault();
        public GamePage()
        {
            this.InitializeComponent();

            BTContinue.Visibility = Visibility.Collapsed;
            HardwareButtons.BackPressed += OnBackPressed;
            IMlife1.DataContext = alive; IMlife2.DataContext = alive; IMlife3.DataContext = alive;

            modes = SharedInformation.sharedMode;
            if (modes == "adventure")
            {
                deff = SharedInformation.sharedPLevel;
                op = SharedInformation.sharedType;
                TFtimer.Visibility = Visibility.Collapsed;
            }
            if (modes == "quizz")
            {
                TFtimer.Visibility = Visibility.Visible;
                TFtimer.DataContext = time;
                timing();
            }

            GameSet();
            
            
        }
        private void GameSet()
        {
            if(modes == "adventure")
            {

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
               
            }
            if (modes == "quizz")
            {
                if(SharedInformation.sharedType== "The Mentalist")
                {
                    j = rnd.Next(7);
                    if (j == 0) { op = "+"; }
                    if (j == 1) { op = "-"; }
                    if (j == 2) { op = "*"; }
                    if (j == 3) { op = "/"; }
                    if (j == 4) { op = "power"; }
                    if (j == 5) { op = "quadra"; }
                    if (j == 6) { op = "Linearty"; }
                }
                if(SharedInformation.sharedType== "Basics")
                {
                    j = rnd.Next(2);
                    if (j == 0) { op = "+"; }
                    if (j == 1) { op = "-"; }
                }
                if (SharedInformation.sharedType == "Multiplication")
                {
                    op = "*";
                }
                if (SharedInformation.sharedType == "Division")
                {
                    op = "/";
                }
                if (SharedInformation.sharedType == "Power Ranger")
                {
                    op = "power";
                }
                if (SharedInformation.sharedType == "Quadratica")
                {
                    op = "quadra";
                }
                if (SharedInformation.sharedType == "Linearty")
                {
                    op = "Linearty";
                }
            }
            nb1 = rnd.Next(10 + deff*2);
            nb2 = rnd.Next(10 + deff*2);

            if (op == "+")
            {
                solution = nb1 + nb2;
            }
            if (op == "-")
            {
                solution = nb1 - nb2;
            }
            if (op == "*")
            {
                solution = nb1 * nb2;
            }
            if (op == "/")
            {
                nb1 = nb2 * nb1;
                solution = nb1 / nb2;
            }

            TFquestion.Text = nb1 + " " + op + " " + nb2;
            if (op == "power")
            {
                nb1 = rnd.Next(11);
                nb2 = rnd.Next(4);
                solution = 1;
                for(int ggg=0;ggg< nb2; ggg++)
                {

                    solution = solution*nb1;
                }
                if (nb2 == 0)
                {
                    TFquestion.Text = nb1 + " º";
                }
                if (nb2 == 1)
                {
                    TFquestion.Text = nb1 + " ¹";
                }
                if (nb2 == 2)
                {
                    TFquestion.Text = nb1 + " ²";
                }
                if (nb2 == 3)
                {
                    TFquestion.Text = nb1 + " ³";
                }
            }

            int seuil = 15;
            if (op == "Linearty")
            {

                int bb;
                int a1, b, c;
                a1 = rnd.Next(9) + 1;
                b = rnd.Next(20) + 5;
                bb = a1 * (rnd.Next(4) + 1);
                c = b - bb;
                if (c >= 0)
                {
                    TFquestion.Text = "" + a1 + "x +" + c + " = " + b;
                }
                else if (c < 0)
                {
                    TFquestion.Text = "" + a1 + "x " + c + " = " + b;
                }

                solution = ((b - c) / a1);
                seuil = 5;

            }
            int choix1 = rnd.Next(1, seuil) + solution;
            int choix2 = 0;
            int choix3 = 0;
            do
            {
                choix2 = rnd.Next(1, seuil) + solution; choix3 = rnd.Next(1, seuil) + solution;
            } while (choix1 == choix2 || choix2 == choix3 || choix1 == choix3 || choix1 == solution || choix2 == solution || choix3 == solution);
            i = rnd.Next(3);
            if (i == 0)
            {
                RP1.Content = solution;
                RP2.Content = choix1;
                RP3.Content = choix2;
                RP4.Content = choix3;
            }
            if (i == 1)
            {
                RP1.Content = choix1;
                RP2.Content = solution;
                RP3.Content = choix2;
                RP4.Content = choix3;
            }
            if (i == 2)
            {
                RP1.Content = choix1;
                RP2.Content = choix2;
                RP3.Content = solution;
                RP4.Content = choix3;
            }
            if (i == 3)
            {
                RP1.Content = choix1;
                RP2.Content = choix2;
                RP3.Content = choix3;
                RP4.Content = solution;
            }

            if (op == "quadra")
            {
                int delta = 0;
                int a, b, c = 0, entier1, entier2;
                a = rnd.Next(4) + 1;
                entier1 = rnd.Next(2);
                entier2 = rnd.Next(2) + 2;
                b = -(entier1 + entier2) * a;
                delta = ((entier2 - entier1) * a);
                delta = delta * delta;
                c = ((b * b) - delta) / (4 * a);

                if (b < 0)
                {
                    TFquestion.Text = a + " x² " + b + " x ";
                }
                else
                {
                    TFquestion.Text = a + " x² + " + b + " x ";
                }
                if (c < 0)
                {
                    TFquestion.Text = TFquestion.Text+c+" = 0";
                }
                else
                {
                    TFquestion.Text = TFquestion.Text+" + "+c+" = 0";
                }

                String solutionCh = "x = [" + entier1 + "," + entier2 + "]";
                String choixx1 = "x = [" + (entier1 + 1) + "," + (entier2 + 0) + "]";
                String choixx2 = "x = [" + (entier1 + 0) + "," + (entier2 + 2) + "]";
                String choixx3="x = [" + (entier1 + 2) + "," + (entier2 + 1) + "]";

                if (i == 0)
                {
                    RP1.Content = solutionCh;
                    RP2.Content = choixx1;
                    RP3.Content = choixx2;
                    RP4.Content = choixx3;
                }
                if (i == 1)
                {
                    RP1.Content = choixx1;
                    RP2.Content = solutionCh;
                    RP3.Content = choixx2;
                    RP4.Content = choixx3;
                }
                if (i == 2)
                {
                    RP1.Content = choixx1;
                    RP2.Content = choixx2;
                    RP3.Content = solutionCh;
                    RP4.Content = choixx3;
                }
                if (i == 3)
                {
                    RP1.Content = choixx1;
                    RP2.Content = choixx2;
                    RP3.Content = choixx3;
                    RP4.Content = solutionCh;
                }
            }
            

        }
        private async void timing()
        {

            do
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                time--;
                TFtimer.DataContext = time;
            } while (time > 0);
            if (time <= 0)
            {
                testVibrationDevice.Vibrate(TimeSpan.FromSeconds(3));


                IMlife1.DataContext = dead; IMlife2.DataContext = dead; IMlife3.DataContext = dead;
                IMlife1.Visibility = Visibility.Collapsed;
                IMlife2.Visibility = Visibility.Collapsed;
                IMlife3.Visibility = Visibility.Collapsed;
                RP1.Visibility = Visibility.Collapsed;
                RP2.Visibility = Visibility.Collapsed;
                RP3.Visibility = Visibility.Collapsed;
                RP4.Visibility = Visibility.Collapsed;
                //TFquestion.Visibility = Visibility.Collapsed;

                BTContinue.Visibility = Visibility.Visible;
                score = 2548 + RPVrais * 250 - RPFaux * 600;
                IsolatedStorageHelper.SaveObject(SharedInformation.sharedType, score);
                TFquestion.Text = "Game Over";
                TFaccuse.Text = "Score = " + score;

            }
        }
        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            // add your own code here to run when Back is pressed
            if (SharedInformation.sharedMode == "quizz")
            {
                HardwareButtons.BackPressed -= OnBackPressed;
                Frame.Navigate(typeof(ChooseQuizz));
            }
            else
            {
                HardwareButtons.BackPressed -= OnBackPressed;
                Frame.Navigate(typeof(AdventureMap));
            }
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void BTIsClicked(int indiceBt)
        {
            if (i == indiceBt)
            {
                TFaccuse.Text = "True";
                RPVrais++;
                deffQuizz++;
                if (deffQuizz == 4 && SharedInformation.sharedMode == "quizz") { deff++; deffQuizz = 0; }
                if (RPVrais == 10 && SharedInformation.sharedMode == "adventure")
                {
                    RP1.Visibility = Visibility.Collapsed;
                    RP2.Visibility = Visibility.Collapsed;
                    RP3.Visibility = Visibility.Collapsed;
                    RP4.Visibility = Visibility.Collapsed;
                    //TFquestion.Visibility = Visibility.Collapsed;

                    BTContinue.Visibility = Visibility.Visible;
                    score = 2548 + RPVrais * 250 - RPFaux * 600;
                    TFquestion.Text = "Chapter Successful";
                    TFaccuse.Text = "Score = " + score;
                    IsolatedStorageHelper.SaveObject(operation + SharedInformation.sharedPLevel, score);
                }
                else
                {
                    GameSet();
                }


            }
            else
            {


                testVibrationDevice.Vibrate(TimeSpan.FromSeconds(1.5));
                TFaccuse.Text = "False";
                lifes--;
                RPFaux++;
                time = time - 10;
                TFtimer.DataContext = time;
                if (lifes == 2) { IMlife3.DataContext = dead; }
                if (lifes == 1) { IMlife2.DataContext = dead; }
                if (lifes == 0)
                {
                    IMlife1.DataContext = dead;
                    RP1.Visibility = Visibility.Collapsed;
                    RP2.Visibility = Visibility.Collapsed;
                    RP3.Visibility = Visibility.Collapsed;
                    RP4.Visibility = Visibility.Collapsed;
                    //TFquestion.Visibility = Visibility.Collapsed;

                    BTContinue.Visibility = Visibility.Visible;
                    if (SharedInformation.sharedMode == "quizz")
                    {
                        TFtimer.Visibility = Visibility.Collapsed;
                        score = 2548 + RPVrais * 250 - RPFaux * 600;
                        IsolatedStorageHelper.SaveObject(SharedInformation.sharedType, score);
                        TFquestion.Text = "Game Over";
                        TFaccuse.Text = "Score = " + score;
                    }else
                    {
                        TFquestion.Visibility = Visibility.Collapsed;
                        TFaccuse.Text = "Chapter Failed";
                    }

                }
            }
        }


        private void RP1_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(0);
            
        }

        private void RP2_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(1);
        }

        private void RP3_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(2);
        }

        private void RP4_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(3);
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            if (SharedInformation.sharedMode == "quizz")
            {
                HardwareButtons.BackPressed -= OnBackPressed;
                Frame.Navigate(typeof(ChooseQuizz));
            }else
            {
                HardwareButtons.BackPressed -= OnBackPressed;
                Frame.Navigate(typeof(AdventureMap));
            }
        }
    }
}
