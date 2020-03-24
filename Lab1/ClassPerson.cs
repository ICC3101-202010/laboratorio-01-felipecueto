using System;
namespace Lab1
{
    public class Person
    {
        //Atributos
        private String Name;
        private String LastName;

        //Comportamiento
        public int Lanzar()
        {
            Random ran = new Random();
            int num = ran.Next(0, 3);
            return num;

        }
        //Constructor
        public Person(String Name, String Lastname)
        {
            this.Name = Name;
            this.LastName = Lastname;
        }
    }
}