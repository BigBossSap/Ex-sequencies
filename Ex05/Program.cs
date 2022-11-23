using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Fer un programa que vagi demanant números fins trobar el zero i calculi la mitjana
   aritmètica dels valors introduïts.
   */

            int num, cont=0, mitjana=0;

            int valors = 0;

            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {


                valors += num;
                cont++;
                
                num = Convert.ToInt32(Console.ReadLine());

            }

            mitjana = valors / cont;
            Console.WriteLine($"\r La mitjana es: {mitjana} !");


        }
    }
}
