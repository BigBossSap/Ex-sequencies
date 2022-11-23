using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Fer un programa que vagi demanant números fins trobar el zero i calculi la suma dels
   valors introduïts.
   */
            int num;
           
            int valors = 0;

            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {


                valors += num;
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"\r El numero  suma {valors} !");


        }
    }
}
