using System;

namespace odun_cramers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number for each varible");
            int a,b,c,d,e,f;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());

            


            int s = (e*d) - (b*f);
            int t = (a*d) - (b*c);//T HERE ACTS AS DETERMINANT
            int r = (a*f) - (e*c);

            int x = s/t;
            int y = r/t;

            if (t == 0)
            {
                Console.WriteLine("the equation as no solution");

            }
            else
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
        }
    }
}
