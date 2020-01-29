using System;
using System.Text.RegularExpressions;

namespace Lab7RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }


        public static string GetName(string name)
        {
            name = GetUserInput(name);
            if (Regex.IsMatch(name, @"^\b[A-Z][a-z]{1,29}\b$"))
            {
                return name;
            }
            else
            {
                return GetName("Please enter only letters\nis less than 30 characters\n" +
                    "& please capitalize your name.");
            }
        }
        public static string GetEMail(string eMail)
        {

            eMail = GetUserInput(eMail);
            if (Regex.IsMatch(eMail, @"^\b[A-z0-9]{5,30}\@[A-z0-9]{5,10}\.[A-z0-9]{2,3}\b$"))
            {
                return eMail;
            }
            else
            {
                return GetEMail("Please enter a valid email.");
            }

        }
        public static string GetPhoneNumber(string phoneNumber)
        {

            phoneNumber = GetUserInput(phoneNumber);
            if (Regex.IsMatch(phoneNumber, @"^\b\d{3}-\d{3}-\d{4}\b$"))
            {
                return phoneNumber;
            }
            else
            {
                return GetUserInput("Please enter a valid phone number");
            }
        }

        public static string GetDate(string date)
        {
            date = GetUserInput(date);
            if (Regex.IsMatch(date, @"^\b\d{2}[/]\d{2}[/]\d{4}\b$"))
            {
                if (DateTime.TryParse(($"{date} 00:00:00 AM"), out DateTime result))
                {
                    return date;
                }
                else
                {
                    return GetDate("Please enter a vaild date. Format dd/mm/yyyy");
                }
            }
            else
            {
                return GetDate("Please enter a vaild date. Format dd/mm/yyyy");
            }
        }
    }
}
