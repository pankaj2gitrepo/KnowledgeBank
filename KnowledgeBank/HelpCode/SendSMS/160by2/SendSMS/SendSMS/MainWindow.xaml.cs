using Nitin.Sms.Api;
using System.Windows;

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
            OneSixtybyTwo o160 = new OneSixtybyTwo("9545623724", "me2160by2");
            o160.Login();
            o160.SendSms("9545623724", "Test Message from 160by2"); 
            lblStatus.Content = string.Concat(lblStatus.Content, "\n", "SMS Sent from 160by2...");

            Way2Sms way2Sms = new Way2Sms("9545623724", "me2way2sms");
            way2Sms.Login();
            way2Sms.SendSms("9545623724", "Test Message from Way2Sms");
            lblStatus.Content = string.Concat(lblStatus.Content, "\n", "SMS Sent from Way2Sms...");
        }
    }
}
