using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newthing
{
    public class User
    {
        public String UserID;
        public String ForeName;
        int Phone;
        public string SurName;
        public String Email;
        public String LoginID;
        Dictionary<String, bool> Notifications;
        //public List<Engagement> Engagements;
        public List<User> Relations;

        public User(string username, string login, string forename, string surname)
        {
            UserID = username;
            ForeName = forename;
            SurName = surname;
            LoginID = login;
            //Engagements = new List<Engagement>();
        }

        public void showNotifications()
        {
            foreach (string notification in Notifications.Keys)
            {
                Console.WriteLine(notification);
            }
        }

        public void /* List<DateTime>*/ GetCalendar()
        {
            Dictionary<DateTime, string> engagements = new Dictionary<DateTime, string>();
            engagements.Add(new DateTime(2023, 11, 13, 9, 30, 0), "M");
            engagements.Add(new DateTime(2023, 11, 14, 10, 30, 0), "R");
            engagements.Add(new DateTime(2023, 11, 13, 14, 0, 0), "M");
            engagements.Add(new DateTime(2023, 11, 16, 16, 0, 0), "R");
            List<List<DateTime>> list = new List<List<DateTime>>();
            DateTime myDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);
            for (int j = 0; j <= 7; j++)
            {
                list.Add(new List<DateTime>());
                for (int i = 0; i <= 7; i++)
                {
                    list[j].Add((myDate.AddDays(j).AddHours(i)));
                    list[j].Add((myDate.AddDays(j).AddHours(i).AddMinutes(30)));
                }
            }
            foreach (List<DateTime> dates in list)
            {
                Console.Write(dates[0].ToString("ddd"));
                Console.Write("              ");
            }
            Console.WriteLine();
            for (int j = 0; j < list[0].Count; j++)
            {
                foreach (List<DateTime> dates in list)
                {
                    engagements.TryGetValue(dates[j], out string mur);
                    if (mur != null)
                    {
                        Console.Write(mur);
                        Console.Write("                ");
                    }
                    else
                    {
                        Console.Write(dates[j].ToString("HH:mm"));
                        Console.Write("            ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }

    public class Student : User
    {

        public Student(string username, string login, string forename, string surname) : base(username, login, forename, surname)
        {

        }

        public String PersonalSupervisor;

        public void MakeReport()
        {

        }
    }

    public class Supervisor : User
    {
        public Supervisor(string username, string login, string forename, string surname) : base(username, login, forename, surname)
        {

        }

        public void ApproveReport()
        {

        }

        public void StudentView()
        {

        }
    }

    public class Tutor : Supervisor
    {
        public Tutor(string username, string login, string forename, string surname) : base(username, login, forename, surname)
        {

        }

        public void SupervisorView()
        {

        }
    }
}

