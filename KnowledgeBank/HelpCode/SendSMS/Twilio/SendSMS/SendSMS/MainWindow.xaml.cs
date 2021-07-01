using System;
using System.Windows;
using Twilio;

namespace SendSMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSendSMS_Click(object sender, RoutedEventArgs e)
        {
            var client = new TwilioRestClient("AC3eeaa706e0b7d50d10bd5ae6371aab33", "035b3ee23e38d35105c976f05bc92b6b");
            client.SendMessage("+16465767698", "+919545478624", "Ahoy from Twilio!");
            lblStatus.Content = string.Concat(lblStatus.Content, "\n", "SMS Sent...");
        }
    }
}
