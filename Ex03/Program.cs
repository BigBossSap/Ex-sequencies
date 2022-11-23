using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Fer un programa que vagi demanant números fins trobar el zero i digui quants valors
   s’han introduït.
   */

            char num;
            int valors = 0;

            Console.WriteLine("num: ");
            num = Console.ReadKey().KeyChar;

            while (num!='0')
            {
                num = Console.ReadKey().KeyChar;
                valors++;
            }

            Console.WriteLine($"\r El numero te {valors} xifres!");

           





        }
    }
}
