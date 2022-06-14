using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace DOB_Mail_Notification
{
    public class MailService
    {
        private readonly static string _sendMailID = "saikumar.wishes@gmail.com";
        private readonly static string _sendMailPassword = "aqzfhhmfulxfowxl";
        private readonly static string _hostID = "smtp.gmail.com";

        public static void SendEmail(Mail_Model mail_Model)
        {
            string to = mail_Model.ToMail; //To address    
            string from = _sendMailID; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = mail_Model.MailBody;
            message.Subject = mail_Model.MailSubject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;

            var SmtpClient = GetSmtpClientDetails();

            try
            {
                SmtpClient.Send(message);
            }
            catch (Exception ex)
            { throw ex; }
        }

        private static SmtpClient GetSmtpClientDetails()
        {
            SmtpClient client = new SmtpClient();
            client.Host = _hostID; //Gmail smtp
            client.Port = 587;

            NetworkCredential basicCredential = new NetworkCredential(_sendMailID, _sendMailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;

            return client;
        }
    }
}
