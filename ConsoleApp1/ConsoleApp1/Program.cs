using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas =
            {
                {5,6,7,8 },
                {1,2,3,4 }
            };

            int a = 0;
            int b = 0;
            int c;
            int d = 0;

            for (int i = 0; i < mas.GetUpperBound(0); i++)
            {
                for (int j = 0; j < mas.GetUpperBound(1); j++)
                {
                    c = mas.GetUpperBound(1);
                    while (c >0)
                    {
                        a += mas[i, j];
                        c--;
                    }
                    if(a > b)
                    {
                        d = j;
                        b = a;
                    }
                    
                }
            }
            Console.WriteLine(d);
    }

		
	}
}
