using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. Fer un programa que vagi demanant números fins trobar el zero i mostri en pantalla el
valor més gran.
*/
            int num, major=0;

            int digit = 0;

            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                                
                digit = num;
                if (num > digit)
                    major = num;
                num = Convert.ToInt32(Console.ReadLine());


            }

           
            Console.WriteLine($"\r La mitjana es: {major} !");
        }
    }
}
