using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Fer un programa que demani una frase i digui quantes lletres a hi ha*/

            char lletra;
            int cont=0;
            string casa = "";
            Console.WriteLine("Escriu una frase, acaba amb intro");
            lletra = Console.ReadKey().KeyChar;

            while (lletra!='\r')
            {
                if (lletra >= 'A' && lletra <= 'z' && )
                    cont++;
                casa += lletra;
                lletra = Console.ReadKey().KeyChar;
                
            }

            Console.WriteLine($"\r La frase {casa} te {cont} lletres");






        }
    }
}
