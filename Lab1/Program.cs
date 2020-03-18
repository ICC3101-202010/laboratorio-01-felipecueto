using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Person person = new Person();
            int numero = person.Lanzar();
            Console.WriteLine(numero);

        }
    }

}
