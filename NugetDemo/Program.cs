using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    class MailMessage
    {
        public void SendEmailAsync()
        {
            try
            {
                //From Address    
                string FromAddress = "mbajirao@outlook.com";
                string FromAdressTitle = "M B Rao";
                //To Address    
                string ToAddress = "mbajirao88@gmail.com";
                string ToAdressTitle = "M Baji Rao";
                string Subject = "Demo Mail";
                string BodyContent = "<h1>Hello Dear <span style='color:red'>User</span>, Welcome to My Website</h1><br/><h3>"+DateTime.Now+"</h3>";

                //Smtp Server    
                string SmtpServer = "smtp.office365.com";
                //Smtp Port Number    
                int SmtpPortNumber = 587;

                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress (FromAdressTitle,FromAddress));
                mimeMessage.To.Add(new MailboxAddress(ToAdressTitle,ToAddress));
                mimeMessage.Subject = Subject; //Subject 
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = BodyContent;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    client.Connect(SmtpServer, SmtpPortNumber, false);
                    client.Authenticate("mbajirao@outlook.com","baji_503");
                    client.SendAsync(mimeMessage);
                    Console.WriteLine("The mail has been sent successfully !!");
                    Console.ReadLine();
                    client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.SendEmailAsync();

            Console.ReadKey();
        }
    }
}
