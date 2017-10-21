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
    public sealed partial class MultiPlayer : Page
    {
        int score1=0;int score2=0; int solution = 0; int deff = 1;int i = 0;int j = 0; String op = "";int nb1 = 0;int nb2 = 0;

        Random rnd = new Random();
        String operation = "";
        public MultiPlayer()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += OnBackPressed;
            TFstatus1.Text = "score = " + score1;
            TFstatus2.Text = "score = " + score2;
            GameSet();
        }

        private void GameSet()
        {
            
            
                    j = rnd.Next(7);
                    if (j == 0) { op = "+"; }
                    if (j == 1) { op = "-"; }
                    if (j == 2) { op = "*"; }
                    if (j == 3) { op = "/"; }
                    if (j == 4) { op = "power"; }
                    if (j == 5) { op = "quadra"; }
                    if (j == 6) { op = "Linearty"; }
                
                
            
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

            TFquestion1.Text = nb1 + " " + op + " " + nb2;
            TFquestion2.Text = nb1 + " " + op + " " + nb2;
            if (op == "power")
            {
                nb1 = rnd.Next(11);
                nb2 = rnd.Next(4);
                solution = 1;
                for (int ggg = 0; ggg < nb2; ggg++)
                {

                    solution = solution * nb1;
                }
                if (nb2 == 0)
                {
                    TFquestion1.Text = nb1 + " º";
                    TFquestion2.Text = nb1 + " º";
                }
                if (nb2 == 1)
                {
                    TFquestion1.Text = nb1 + " ¹";
                    TFquestion2.Text = nb1 + " ¹";
                }
                if (nb2 == 2)
                {
                    TFquestion1.Text = nb1 + " ²";
                    TFquestion2.Text = nb1 + " ²";
                }
                if (nb2 == 3)
                {
                    TFquestion1.Text = nb1 + " ³";
                    TFquestion2.Text = nb1 + " ³";
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
                    TFquestion1.Text = "" + a1 + "x +" + c + " = " + b;
                    TFquestion2.Text = "" + a1 + "x +" + c + " = " + b;
                }
                else if (c < 0)
                {
                    TFquestion1.Text = "" + a1 + "x " + c + " = " + b;
                    TFquestion2.Text = "" + a1 + "x " + c + " = " + b;
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
            } while (choix1 == choix2 || choix2 == choix3 || choix1 == choix3 || choix1== solution || choix2 == solution || choix3 == solution);
            i = rnd.Next(3);
            if (i == 0)
            {
                button11.Content = solution;
                button12.Content = choix1;
                button13.Content = choix2;
                button14.Content = choix3;

                button21.Content = solution;
                button22.Content = choix1;
                button23.Content = choix2;
                button24.Content = choix3;
            }
            if (i == 1)
            {
                button11.Content = choix1;
                button12.Content = solution;
                button13.Content = choix2;
                button14.Content = choix3;

                button21.Content = choix1;
                button22.Content = solution;
                button23.Content = choix2;
                button24.Content = choix3;
            }
            if (i == 2)
            {
                button11.Content = choix1;
                button12.Content = choix2;
                button13.Content = solution;
                button14.Content = choix3;

                button21.Content = choix1;
                button22.Content = choix2;
                button23.Content = solution;
                button24.Content = choix3;
            }
            if (i == 3)
            {
                button11.Content = choix1;
                button12.Content = choix2;
                button13.Content = choix3;
                button14.Content = solution;


                button21.Content = choix1;
                button22.Content = choix2;
                button23.Content = choix3;
                button24.Content = solution;
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
                    TFquestion1.Text = a + " x² " + b + " x ";
                    TFquestion2.Text = a + " x² " + b + " x ";
                }
                else
                {
                    TFquestion1.Text = a + " x² + " + b + " x ";
                    TFquestion2.Text = a + " x² + " + b + " x ";
                }
                if (c < 0)
                {
                    TFquestion1.Text = TFquestion1.Text + c + " = 0";
                    TFquestion2.Text = TFquestion2.Text + c + " = 0";
                }
                else
                {
                    TFquestion1.Text = TFquestion1.Text + " + " + c + " = 0";
                    TFquestion2.Text = TFquestion2.Text + " + " + c + " = 0";
                }

                String solutionCh = "x = [" + entier1 + "," + entier2 + "]";
                String choixx1 = "x = [" + (entier1 + 1) + "," + (entier2 + 0) + "]";
                String choixx2 = "x = [" + (entier1 + 0) + "," + (entier2 + 2) + "]";
                String choixx3 = "x = [" + (entier1 + 2) + "," + (entier2 + 1) + "]";

                if (i == 0)
                {
                    button11.Content = solutionCh;
                    button12.Content = choixx1;
                    button13.Content = choixx2;
                    button14.Content = choixx3;

                    button21.Content = solutionCh;
                    button22.Content = choixx1;
                    button23.Content = choixx2;
                    button24.Content = choixx3;
                }
                if (i == 1)
                {
                    button11.Content = choixx1;
                    button12.Content = solutionCh;
                    button13.Content = choixx2;
                    button14.Content = choixx3;

                    button21.Content = choixx1;
                    button22.Content = solutionCh;
                    button23.Content = choixx2;
                    button24.Content = choixx3;
                }
                if (i == 2)
                {
                    button11.Content = choixx1;
                    button12.Content = choixx2;
                    button13.Content = solutionCh;
                    button14.Content = choixx3;

                    button21.Content = choixx1;
                    button22.Content = choixx2;
                    button23.Content = solutionCh;
                    button24.Content = choixx3;
                }
                if (i == 3)
                {
                    button11.Content = choixx1;
                    button12.Content = choixx2;
                    button13.Content = choixx3;
                    button14.Content = solutionCh;


                    button21.Content = choixx1;
                    button22.Content = choixx2;
                    button23.Content = choixx3;
                    button24.Content = solutionCh;
                }
            }


        }




        private void BTIsClicked(int indiceBt,int player)
        {
            if (i == indiceBt)
            {
                deff++;
                if (player == 1)
                {
                    score1++;
                    TFstatus1.Text = "score = " + score1;
                }
                else
                {
                    score2++;
                    TFstatus2.Text = "score = " + score2;
                }
                if (score1 == 10)
                {
                    button11.Visibility = Visibility.Collapsed;
                    button12.Visibility = Visibility.Collapsed;
                    button13.Visibility = Visibility.Collapsed;
                    button14.Visibility = Visibility.Collapsed;

                    button21.Visibility = Visibility.Collapsed;
                    button22.Visibility = Visibility.Collapsed;
                    button23.Visibility = Visibility.Collapsed;
                    button24.Visibility = Visibility.Collapsed;
                    TFquestion1.Text = "You WIN";
                    TFquestion2.Text = "You LOSE";
                }
                else if (score2 == 10)
                {
                    button11.Visibility = Visibility.Collapsed;
                    button12.Visibility = Visibility.Collapsed;
                    button13.Visibility = Visibility.Collapsed;
                    button14.Visibility = Visibility.Collapsed;

                    button21.Visibility = Visibility.Collapsed;
                    button22.Visibility = Visibility.Collapsed;
                    button23.Visibility = Visibility.Collapsed;
                    button24.Visibility = Visibility.Collapsed;
                    TFquestion1.Text = "You LOSE";
                    TFquestion2.Text = "You WIN";
                }
                else
                {
                    GameSet();
                }


            }
            else
            {
                if (player == 1)
                {
                    score1--;
                    TFstatus1.Text = "score = " + score1;
                }
                else
                {
                    score2--;
                    TFstatus2.Text = "score = " + score2;
                }
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
        private async void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            
                HardwareButtons.BackPressed -= OnBackPressed;
                Frame.Navigate(typeof(ChooseMode));
            
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(0, 1);
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(1, 1);
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(2, 1);
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(3, 1);
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(0, 2);
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(1, 2);
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(2, 2);
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            BTIsClicked(3, 2);
        }
    }
}
