using AyuboDrive.Utility;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    /// <summary>
    /// This class can be used to send a simple email that conly contains a subject and body. 
    /// No HTML whatsoever. The necessary details liek mail server, port number, etc. are
    /// stored in the configuration file
    /// </summary>
    class SimpleEmailSender
    {
        private readonly string _senderName = "AyuboDrive";

        public bool SendEmail(string subject, string body)
        {
            MimeMessage message = GenerateMimeMessage(subject, body);
            
            if(message != null)
            {
                try
                {
                    using (SmtpClient smtpClient = new SmtpClient())
                    {
                        smtpClient.Connect(ConfigurationHandler.GetMailServer(), 
                            ConfigurationHandler.GetPort(), true);
                        smtpClient.Authenticate(ConfigurationHandler.GetSenderEmail(), 
                            ConfigurationHandler.GetPassword());
                        smtpClient.Send(message);
                        return true;
                    }
                }
                catch(System.Net.Sockets.SocketException ex)
                {
                    MessagePrinter.PrintToConsole(ex.ToString(), "Network error");
                }
                catch (Exception ex)
                {
                    MessagePrinter.PrintToConsole(ex.ToString(), "An error occured when sending the mail");
                }
            }
            return false;
        }

        private MimeMessage GenerateMimeMessage(string subject, string body)
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(_senderName, ConfigurationHandler.GetSenderEmail()));
                message.To.Add(MailboxAddress.Parse(ConfigurationHandler.GetReceiverEmail()));
                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body };
                return message;
            }
            catch (Exception ex)
            {
                MessagePrinter.PrintToConsole(ex.ToString(), "An error occured when generating the message");
                return null;
            }
        }
    }
}
