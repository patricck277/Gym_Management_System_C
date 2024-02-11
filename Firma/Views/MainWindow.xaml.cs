using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Firma
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer countdownTimer;
        private TimeSpan timeLeft;

        public MainWindow()
        {
            InitializeComponent();
            StartCountdown();
        }

        private void StartCountdown()
        {
            // czass startowy
            timeLeft = TimeSpan.FromMinutes(10);

            // timer
            countdownTimer = new DispatcherTimer();
            countdownTimer.Interval = TimeSpan.FromSeconds(1);
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Odejmowani
            timeLeft = timeLeft.Add(TimeSpan.FromSeconds(-1));

            // Aktualizacja
            countdownTextBlock.Text = $"Time left: {timeLeft.Minutes} Minutes, {timeLeft.Seconds} Seconds";

            
            if (timeLeft <= TimeSpan.Zero)
            {
             
                countdownTimer.Stop();

              
                countdownTextBlock.Text = "Time's up! The program will close in 10 sec.";

                // Opóźnienie
                DispatcherTimer exitTimer = new DispatcherTimer();
                exitTimer.Interval = TimeSpan.FromSeconds(10);
                exitTimer.Tick += (s, args) =>
                {
                    
                    Application.Current.Shutdown();
                    exitTimer.Stop(); 
                };
                exitTimer.Start(); 
            }
        }
    }
}
