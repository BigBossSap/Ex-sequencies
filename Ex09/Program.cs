using System;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, ant;
            bool creixent = true, decreixent = true;
            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());
            ant = int.MinValue;


            while (num != 0)

            {


                if (ant < num)
                    creixent = false;
                if (ant > num)
                    decreixent = false;

                ant = num;
                num = Convert.ToInt32(Console.ReadLine());
            }

            if (creixent)
                Console.WriteLine("creix");
            else if (decreixent)
                Console.WriteLine("decreix");
            else
                Console.WriteLine("ni una");
        }

    }
    }
}
