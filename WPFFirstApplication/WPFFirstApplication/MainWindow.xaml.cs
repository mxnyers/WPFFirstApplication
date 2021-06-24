using System;
using System.Windows;
using System.Windows.Controls;
using WPFFirstApplication.Models;


namespace WPFFirstApplication
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

        public SentEmails EmailList = new SentEmails();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SentEmails l_SentEmails = new SentEmails();
            Email l_Email = new Email();
            l_Email.SubjectLine = SubjectLineTextEntry.Text;
            l_Email.SendTo = SendToComboBox.Text;
            l_Email.EmailText = EmailTextEntry.Text;
            l_SentEmails.Emails.Add(l_Email);
            EmailList.Emails.Add(l_Email);
            string ConfirmationMessage = String.Format("Email with the subject: {0} \nWas sent to: {1} \nWith the message: {2}", SubjectLineTextEntry.Text, SendToComboBox.Text, EmailTextEntry.Text);
            MessageBox.Show(ConfirmationMessage, "Succes!");
            SubjectLineTextEntry.Clear();
            EmailTextEntry.Clear();
            if(EmailList.Emails.Count > 0)
            {
                EmailsSentTab.Visibility = Visibility.Visible;
                SentEmailsDataGrid.ItemsSource = null;
                SentEmailsDataGrid.ItemsSource = EmailList.Emails;
            }

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
