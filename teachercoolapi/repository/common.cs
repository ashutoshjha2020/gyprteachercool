using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace teachercoolapi.repository
{
    public class common
    {
        public string generateotp()
        {
            Random generator = new Random();
            int r = generator.Next(100000, 1000000);
            return r.ToString();
        }
        public void sendEmail(string toemail, string subject, string body)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("noreply@mavenscare.com");
                message.To.Add(new MailAddress(toemail));
                message.Subject = subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = body;
                smtp.Port = 25;
                smtp.Host = "mavenscare.com"; //for gmail host  
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("noreply@mavenscare.com", "Welcome@2020");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }

        public string getIP()
        {
            string ipAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ipAddress))
            {
                ipAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            //string APIKey = "<Your API Key>";
            //string url = string.Format("http://api.ipinfodb.com/v3/ip-city/?key={0}&ip={1}&format=json", APIKey, ipAddress);

            //string ip = HttpContext.Current.Request.UserHostAddress;
            return ipAddress;
        }
    }
}