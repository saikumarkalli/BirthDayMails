using System;
using System.Collections.Generic;
using System.Text;

namespace DOB_Mail_Notification
{
    public class EmailMethods
    {
        public void GenerateBirtdayData()
        {
            var datalist = Mail_DB.GetMembersList();

            string date = DateTime.UtcNow.ToString("dd-MM");

            var birthday = datalist.FindAll(x => x.DOB == date && x.Status == true);

            foreach (var iteam in birthday)
            {
                Mail_Model mail_Model = new Mail_Model();
                mail_Model.ToMail = iteam.Email;

                mail_Model.MailBody = "Happy Birthday! " + iteam.Name + "" + iteam.LastName + "";
                mail_Model.MailSubject = iteam.Message + " Wishes from Sai Kumar Kalli";

                MailService.SendEmail(mail_Model);
            }

        }
    }
}
