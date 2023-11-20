using System;
using System.Collections.Generic;

namespace StudentPortalSMS
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string StudentNumber { get; set; }
    }

    class Program
    {
        static Dictionary<string, User> userCredentials = new Dictionary<string, User>()
        {
            { "nanakt", new User { Username = "nanakt", Password = "tknana", StudentNumber = "20624018" } },
            { "obrempong", new User { Username = "obrempong", Password = "obrempong123", StudentNumber = "20625018" } },
            { "miki480", new User { Username = "miki480", Password = "mikik4800", StudentNumber = "20626018" } },
            { "eadjei35", new User { Username = "eadjei35", Password = "3lkwiy1", StudentNumber = "20627018" } }
        };

        static void Profile()
        {
            Console.WriteLine("Please enter your username: ");
            string inputUsername = Console.ReadLine();

            if (userCredentials.TryGetValue(inputUsername, out User user))
            {
                Console.WriteLine("Please enter your password: ");
                string inputPassword = Console.ReadLine();


                Console.WriteLine("Please enter your Student ID Number: ");
                string inputStudentNumber = Console.ReadLine();

                if (inputPassword == user.Password && inputStudentNumber == user.StudentNumber)
                {
                    Console.WriteLine($"Login successful! Welcome to KNUST Students' Serial Code Portal, {user.Username}!");
                }
                else
                {
                    Console.WriteLine("Invalid password or Student ID Number. Exiting program.");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Invalid username. Exiting program.");
                Environment.Exit(0);
            }
        }

        static void FirstPage(string shortcode = "*713*001#")
        {
            Console.WriteLine("Please enter the shortcode: ");
            string userShortcode = Console.ReadLine();

            if (shortcode == userShortcode)
            {
                Console.WriteLine("Welcome to KNUST Students Portal.");
                Console.WriteLine("\n1. Profile\n2. Course Registration\n3. Option Change\n4. Registration Slip\n5. Check Results\n6. Assess Lecturer\n7. Next Page");
                string chooseOption = Console.ReadLine();

                if (chooseOption == "7")
                {
                    Console.WriteLine("\n1. Bill and Payments\n2. Biometric Verification\n0. Go back");
                }
                else if (chooseOption == "1")
                {
                    Profile();
                }
                else if (chooseOption == "0")
                {
                    Console.WriteLine("\n1. Profile\n2. Course Registration\n3. Option Change\n4. Registration Slip\n5. Check Results\n6. Assess Lecturer\n7. Next Page");
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Invalid shortcode. Exiting program.");
                Environment.Exit(0);
            }
            
        }

        static void Main(string[] args)
        {
            FirstPage();
            Console.ReadKey();
        }
    }
}
