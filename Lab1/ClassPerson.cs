using System;
namespace Lab1
{
    public class Person
    {
        //Atributos
        public String Name;
        public String LastName;

        //Comportamiento
        public int Lanzar()
        {
            Random ran = new Random();
            int num = ran.Next(0, 3);
            return num;

        }

    }
}