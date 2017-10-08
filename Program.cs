using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using (var db = new ApplicationContext())
                {

                    // Creating a new item and saving it to the database
                    var newUser = new User();
                    newUser.Id = 1;
                    newUser.Name = "Red Apple";
                    newUser.Age = 12;
                    db.Users.Add(newUser);
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} records saved to database", count);

                    //// Retrieving and displaying data
                    //Console.WriteLine();
                    //Console.WriteLine("All items in the database:");
                    //foreach (var user in db.Users)
                    //{
                    //    Console.WriteLine("{0} | {1}", user.Name, user.Age);
                    //}
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
        }
    }
}