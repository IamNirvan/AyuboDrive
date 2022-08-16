using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    class EmailSender
    {
        private readonly string Sender;
        private readonly string Receiver;
        private readonly string SenderName;
        private readonly string Password;

        public EmailSender(string senderEmail, string receiverEmail, string name, string password)
        {
            Sender = senderEmail;
            Receiver = receiverEmail;
            SenderName = name;
            // wuxrfgttqosyplba
            Password = password;
        }

        public bool SendEmail(string subject, string body)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(SenderName, Sender));
            message.To.Add(MailboxAddress.Parse(Receiver));

            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = body };
            
            try
            {
                using(SmtpClient smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("smtp.gmail.com", 465, true);
                    smtpClient.Authenticate(Sender, Password);
                    smtpClient.Send(message);

                    Console.WriteLine("Email sent successfully");
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
    }
}
