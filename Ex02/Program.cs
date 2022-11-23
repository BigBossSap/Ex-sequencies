using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Fer un programa que demani una frase i digui si hi ha alguna lletra a.
    */

            char lletra;
            Console.WriteLine("Escriu frase, acaba amb intro: ");
            lletra = (char)Console.Read();

            while (lletra != '\r' && lletra!='a' && lletra!='A')
            {
                lletra = (char)Console.Read();
            }

            if (lletra == 'a' || lletra == 'A')
                Console.WriteLine("He trobat una 'a'");
            else
                Console.WriteLine("No ha trobat cap 'a'");

        }
    }
}
