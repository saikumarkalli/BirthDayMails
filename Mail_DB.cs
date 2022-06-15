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

            dbList.Add(new DB_List { Name = "Sai Kumar", LastName = "Kalli", DOB = "15-06", Year = 1999, Email = "kallileelasaikumar@gmail.com", Message = "Birth Day", Status = true });
            dbList.Add(new DB_List { Name = "Aswanth", LastName = "Kalli", DOB = "13-12", Year = 2000, Email = "saikumar.klsk@gmail.com", Message = "Birth Day", Status = true });
            dbList.Add(new DB_List() { Name = "Balaji", LastName = "K", DOB = "10-06", Year = 1998, Email = "balajikulkarni161@gmail.com", Message = "Birth Day", Status = true });
            dbList.Add(new DB_List() { Name = "Ali", LastName = "Shaik", DOB = "13-06", Year = 1998, Email = "Muqthiar1998@gmail.com", Message = "Birth Day", Status = true });
            dbList.Add(new DB_List() { Name = "Anusha ", LastName = "B", DOB = "15-06", Year = 1998, Email = "anushaboddu1999@gmail.com", Message = "Birth Day", Status = true }); //28-10-1999

            return dbList;

        }

    }


}
