using System;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8. Fer un programa que demani números fins trobar el zero i digui si la sèrie era creixent.
 */



            int num, ant; 
            bool creixent = true;
            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());
            ant = int.MinValue;
            
            
            while (num!=0)

            {
                
                
                if (ant<=num)
                    creixent = false;
                else if (ant >= num)

                ant = num;
                num = Convert.ToInt32(Console.ReadLine());
            }
               
            if(creixent)
                Console.WriteLine("si");
            else
                Console.WriteLine("no");
        }
    }
}
