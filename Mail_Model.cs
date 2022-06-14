namespace DOB_Mail_Notification
{
    public class Mail_Model
    {
        public string ToMail { get; set; }
        public string MailBody { get; set; }
        public string MailSubject { get; set; }
        public string SenderType { get; set; }
    }

    public class DB_List
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public int Year { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
