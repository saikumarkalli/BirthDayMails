using System;

namespace DOB_Mail_Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EmailMethods emailMethods = new EmailMethods();
            emailMethods.GenerateBirtdayMails();
        }
    }
}
