using System;
using ConsoleApp1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
           {
               new User("Darko","345"),
               new User("Ivana","123"),
               new User("Angel","567")
           };

            Console.WriteLine("Enter a 1 on 2 : 1 is Login, 2 is Register");

            var input = Console.ReadLine();

            while (true)
            {
                if (input != "1" || input != "2")
                {
                    Console.WriteLine("Invalid input of number");
                    break;
                }
            }

            if (input == "1")
            {
                Console.WriteLine("Enter a user");
                var riduse = Console.ReadLine();

                Console.WriteLine("Enter a pasword");
                var ridpassword = Console.ReadLine();

                foreach (var user in users)
                {
                    if (user.Login == riduse && user.Pasword == ridpassword)
                    {
                        Console.WriteLine("Well you'r user is corect  WELCOME");
                    }
                    else
                    {
                        Console.WriteLine("Invalit User or Password");
                    }
                }


            }
            else if (input == "2")
            {
                Console.WriteLine("Enter your new login user");
                var newuse = Console.ReadLine();

                Console.WriteLine("Enter a your new pasword");
                var newpassword = Console.ReadLine();

                Array.Resize(ref arrUsers, arrUsers.Length + 1);
                arrUsers[arrUsers.Length - 1] = new Users(username, password, id);


            }
            //Console.WriteLine($"Your user is: {user} ,End your pasword is:***");
            Console.ReadLine();

        }
    }
}
    
