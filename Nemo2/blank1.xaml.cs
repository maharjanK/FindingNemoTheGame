using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Nemo2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class blank1 : Page
    {
        int score;
        DispatcherTimer timer;
        int maxTime = 30;
        Stack<int> mystack=new Stack<int>(); 
        public blank1()
        {
            this.InitializeComponent();
            firstrun();
            
        }
        public void firstrun()
        {
            img1.Visibility = Visibility.Collapsed;
            img2.Visibility = Visibility.Collapsed;
            img3.Visibility = Visibility.Collapsed;
            img4.Visibility = Visibility.Collapsed;
            img5.Visibility = Visibility.Collapsed;
            img6.Visibility = Visibility.Collapsed;
            menu.Visibility = Visibility.Collapsed;
            Exit.Visibility = Visibility.Collapsed;
            Retry.Visibility = Visibility.Collapsed;

            Random num = new Random();
            int n = num.Next(1, 6);
            if (n == 1)
            {
                img1.Visibility = Visibility.Visible;
            }
            else if (n == 2)
            {
                img2.Visibility = Visibility.Visible;
            }
            else if (n == 3)
            {
                img3.Visibility = Visibility.Visible;
            }
            else if (n == 4)
            {
                img4.Visibility = Visibility.Visible;
            }
            else if (n == 5)
            {
                img5.Visibility = Visibility.Visible;
            }
            else if (n == 6)
            {
                img6.Visibility = Visibility.Visible;
            }
        }

        private void img1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            img1.Visibility = Visibility.Collapsed;
            img2.Visibility = Visibility.Visible;
            score++;
            txtbox.Text = score.ToString();
        }

        private void img2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            img2.Visibility = Visibility.Collapsed;
            img3.Visibility = Visibility.Visible;
            score++;
            txtbox.Text = score.ToString();
        }

        private void img3_Tapped(object sender, TappedRoutedEventArgs e)
        {
       img3.Visibility = Visibility.Collapsed;
            img4.Visibility = Visibility.Visible;
            score++;
            txtbox.Text = score.ToString();
        }

        private void img4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            img4.Visibility = Visibility.Collapsed;
            img5.Visibility = Visibility.Visible;
            score++;
            txtbox.Text = score.ToString();
        }

        private void img5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            img5.Visibility = Visibility.Collapsed;
            img6.Visibility = Visibility.Visible;
            score++;
            txtbox.Text = score.ToString();

        }

        private void img6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            img6.Visibility = Visibility.Collapsed;
            
            Random num = new Random();
            int n = num.Next(1, 6);

            if (n == 1)
            {
                img1.Visibility = Visibility.Visible;
            }
            else if (n == 2)
            {
                img2.Visibility = Visibility.Visible;
            }
            else if (n == 3)
            {
                img3.Visibility = Visibility.Visible;
            }
            else if (n == 4)
            {
                img4.Visibility = Visibility.Visible;
            }
            else if (n == 5)
            {
                img5.Visibility = Visibility.Visible;
            }
            else if (n == 6)
            {
                img1.Visibility = Visibility.Visible;
            }
            score++;
            txtbox.Text = score.ToString();
        }

        private void dump1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            timer.Stop();
            this.Frame.Navigate(typeof(finalpage));
        }

        private void dump1_Copy3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            timer.Stop();
            this.Frame.Navigate(typeof(finalpage));
        }

        private void dump1_Copy2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            timer.Stop();
            this.Frame.Navigate(typeof(finalpage));
        }

        private void dump1_Copy1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            timer.Stop();
            this.Frame.Navigate(typeof(finalpage));
        }

        private void dump1_Copy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            timer.Stop();
            this.Frame.Navigate(typeof(finalpage));
        }

        private async void dump1_Copy4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            timer.Stop();
            //this.Frame.Navigate(typeof(finalpage));
            animate5.Begin();
            var Messagedialog = new MessageDialog("Opps u clicked the wrong fish!! Your score is " + score.ToString());
            Messagedialog.Commands.Add(new UICommand("Playagain", (UICommandInvokedHandler) =>
            { this.Frame.Navigate(typeof(MainPage)); }));
            await Messagedialog.ShowAsync();

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            mystack.Push(1); 
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            //for Animation
            animate1.Begin();
            animate2.Begin();
            animate3.Begin();
            animate4.Begin();
            animateShark.Begin();
            animatebubble.Begin();
            animatebubble2.Begin();
            animatebubble3.Begin();
            
            //bubbleAnimate.Begin();
            //animateNemo.Begin();
            

        }
        async void  timer_Tick(object sender, object e)
        {
            maxTime--;
            timer1.Text = maxTime.ToString();
            if (maxTime <= 0)
            {
               
                timer.Stop();
                var Messagedialog = new MessageDialog("Time's Up!! Your score is " + score.ToString());
                Messagedialog.Commands.Add(new UICommand("Playagain", (UICommandInvokedHandler) =>
                       { this.Frame.Navigate(typeof(MainPage)); }));
                await Messagedialog.ShowAsync();
                
            }
        }

      

        private void Exit_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();

        }

        private void Retry_Tapped(object sender, TappedRoutedEventArgs e)
        {
            score = 0;
            maxTime = 30;
            txtbox.Text = score.ToString();
            timer1.Text = maxTime.ToString();
            firstrun();
            menu.Visibility = Visibility.Collapsed;
            Exit.Visibility = Visibility.Collapsed;
            Retry.Visibility = Visibility.Collapsed;
            animate1.Resume();
            animate2.Resume();
            animate3.Resume();
            animate4.Resume();
            animatebubble.Resume();
            animatebubble2.Resume();
            animatebubble3.Resume();

            timer.Start();
            mystack.Push(1);

        }

        private void Grid_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {

            int temp;
            
            temp = mystack.Pop();
            if (temp == 1)
            {
                menu.Visibility = Visibility.Visible;
                Exit.Visibility = Visibility.Visible;
                Retry.Visibility = Visibility.Visible;
                animate1.Pause();
                animate2.Pause();
                animate3.Pause();
                animate4.Pause();
                animatebubble.Pause();
                animatebubble2.Pause();
                animatebubble3.Pause();

                timer.Stop();
                mystack.Push(2);
            }
            else
            {
                menu.Visibility = Visibility.Collapsed;
                Exit.Visibility = Visibility.Collapsed;
                Retry.Visibility = Visibility.Collapsed;
                animate1.Resume();
                animate2.Resume();
                animate3.Resume();
                animate4.Resume();
                animatebubble.Resume();
                animatebubble2.Resume();
                animatebubble3.Resume();
             
                timer.Start();
                mystack.Push(1);
            }

        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
           

        }

       

        
    }
}
