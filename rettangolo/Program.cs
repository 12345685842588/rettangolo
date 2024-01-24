using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float l1=float.Parse(Console.ReadLine());
            float l2=float.Parse(Console.ReadLine());

            Rettangolo r = new Rettangolo(l1,l2);

            Console.WriteLine("area: {0}, perimetro:{1}", r.Area(), r.Perimetro());

            Console.ReadLine();
        }
    }
}
