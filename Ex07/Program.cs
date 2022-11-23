using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Fer un programa que demani una llista de números positius acabada en -1 i mostri la
    diferència entre el major i el menor.*/


            int num, major = int.MinValue, menor=int.MaxValue;
            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != -1)
            {
                if (num >= 0)
                {
                    if (num > major)

                        major = num;





                    if (num < menor)
                    {

                        menor = num;
                    }
                   
            
                }

                num = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine($"\r La diferencia entre el major {major} y el menor {menor} es: {major-menor}!");

        }
    }
}
