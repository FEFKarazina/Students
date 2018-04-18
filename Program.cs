using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palchikov_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько уВас денег?");
            double m = Convert.ToDouble(Console.ReadLine());
                        
            Console.WriteLine("Сколько стоит пакет молока?");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько штук хотите купить?");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько стоит булочка?");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько штук хотите купить?");
            int y = Convert.ToInt32(Console.ReadLine());

            double s = x1 * x + y1 * y;
            Console.WriteLine($"{x1} * {x} + {y1} * {y} = {s}");
            double ost = m - s;
            if (ost >= 0)
                {
                Console.WriteLine("У Вас осталось");
                Console.WriteLine(ost);
                }
            else if (ost < 0)
                {
                Console.WriteLine("Вам не хватает");
                Console.WriteLine(-ost);
                }
        }
    }
}
