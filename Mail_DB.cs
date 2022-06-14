using System;
using System.Collections.Generic;
using System.Text;

namespace DOB_Mail_Notification
{
    public static class Mail_DB
    {

        public static List<DB_List> GetMembersList()
        {
            var dbList = new List<DB_List>();

            dbList.Add(new DB_List { Name = "Sai Kumar", LastName = "Kalli", DOB = "14-06", Year = 1999, Email = "kallileelasaikumar@gmail.com", Message = "Birth Day", Status = true });
            dbList.Add(new DB_List { Name = "Aswanth", LastName = "Kalli", DOB = "13-12", Year = 2000, Email = "saikumar.klsk@gmail.com", Message = "Birth Day", Status = true });
            dbList.Add(new DB_List() { Name = "Balaji", LastName = "K", DOB = "10-06", Year = 1998, Email = "balajikulkarni161@gmail.com", Message = "Birth Day", Status = true });

            return dbList;

        }

    }


}
