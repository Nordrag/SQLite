using System;
using System.Linq;

namespace SQLiteTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext MyDatabase = new ApplicationDbContext();

            if (MyDatabase.UserTable.Count() == 0)
            {
                MyDatabase.UserTable.Add(new User 
                { 
                    UserName = "Iván",
                    Password = "123"
                });

                MyDatabase.SaveChanges();
            }

            var User = MyDatabase.UserTable.FirstOrDefault();

            Console.WriteLine(User.UserName + " " + User.Password);
        }
    }
}
