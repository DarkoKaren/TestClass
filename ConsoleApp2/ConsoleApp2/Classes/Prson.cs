using System;

namespace ConsoleApp2.Classes
{
   public class Prson
    {

        public String Name { set; get; }
        public String LastName { set; get; }
        public int Age;
        private string v1;
        private string v2;
        private int v3;
        private string v4;

        public Prson(string v1, string v2, int v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public String Works { set; get; }
    }
}
