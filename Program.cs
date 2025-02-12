using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inserte la base");
            int b= int.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserte la altura");
            int h= int.Parse(Console.ReadLine());
            int A = (b * h) / 2;
            System.Console.WriteLine("El resultado es"+A);
            Console.ReadKey();

        }
    }
}
