using ConsoleApp2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to programs of SEDC/n");

            List<Prson> list = new List<Prson>()
            {
               new Prson("Viktor","Jakovlev",26,"Webdiveloper"),
               new Prson("Viktor","Nakev",28,"Webdiveloper"),
               new Prson("Viktorija","Jakovleva",24,"Studend"),
               new Prson("Miodrag","Cekik",22,"Treners"),
               new Prson("Ivan","Trajcev",26,"Student"),
            };
             

            Console.ReadLine();

        }
    }
}
