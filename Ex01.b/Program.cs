using System;

namespace Ex01.b
{
    class Program
    {
        static void Main(string[] args)
        {
            char lletra;
            int cont = 0;
            string casa = "";
            Console.WriteLine("Escriu una frase, acaba amb intro");
            lletra = Console.ReadKey().KeyChar;

            while (lletra != '\r')
            {
                if (lletra == 'A' || lletra== 'a' )
                    cont++;
                casa += lletra;
                lletra = Console.ReadKey().KeyChar;

            }

            Console.WriteLine($"\r La frase {casa} te {cont} lletres 'a' ");

        }
    }
}

