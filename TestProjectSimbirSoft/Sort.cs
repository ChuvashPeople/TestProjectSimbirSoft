using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProjectSimbirSoft
{
    class Sort
    {
        public static void SortPage(string[] text)
        {
            var result = from i in text
                         group i by i into g
                         select new
                         {
                             Name = g.Key,
                             Count = g.Count()
                         };
            Console.WriteLine();
            Console.WriteLine("Статистика по количеству уникальных слов: ");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Count} ");
            }
        }
    }
}
