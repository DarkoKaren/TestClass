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

            List<Student> students = new List<Student>()
            {
               new Student("Viktor","Jakovlev",26,"Webdiveloper"),
               new Student("Viktor","Nakev",28,"Webdiveloper"),
               new Student("Viktorija","Jakovleva",24,"Studend"),
               new Student("Ivan","Trajcev",26,"Student"),
            };

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }

            Console.ReadLine();

        }
    }
}
