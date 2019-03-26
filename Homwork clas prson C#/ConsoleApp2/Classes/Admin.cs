using System;
using System.Collections.Generic;

namespace ConsoleApp2.Classes
{
    public class Admin : Prson
    {
        public string User { get; set; }
        public string Pasword { get; set; }
        public List<Trainer> Treners { get; set; }
        public Student tutorials {get;set;}

        public Admin(string firstname, string lastname, int age, string works)
        {
            Name = firstname;
            LastName = lastname;
            Age = age;
            Profession = works;
        }
    }
}
