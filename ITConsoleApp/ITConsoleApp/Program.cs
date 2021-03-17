using System;

namespace ITConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = {2, -1, 1, 2, 3, -2 };
            int t = 0;
            for (int i = 0; i < mas.Length-1; i++)
            {
                for (int j = i+1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        t = mas[i];
                        mas[i] = mas[j];
                        mas[j] = t;
                    }
                }
            }
            foreach (var u in mas)
            {
                Console.Write(u + " ");
            }
        }
    }
}
