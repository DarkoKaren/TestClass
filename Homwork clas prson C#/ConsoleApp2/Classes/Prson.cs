using System;

namespace ConsoleApp2.Classes
{
   public class Prson
    {

        public string Name { set; get; }
        public string LastName { set; get; }
        public int Age { get; set; }
        public string Profession { get; set; }

        public Prson(string firstname, string lastname, int age, string Proffesion)
        {
            Name = firstname;
            LastName = lastname;
        }
       

        public string Works { set; get; }
    }
}
