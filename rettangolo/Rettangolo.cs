using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rettangolo
{
    internal class Rettangolo
    {
        public float l1 { get; set; }
        public float l2 { get; set; }

        public Rettangolo(float l1, float l2)
        {
            this.l1 = l1;
            this.l2 = l2;
        }

        public float Area()
        {
            return l1 * l2;
        }

        public float Perimetro()
        {
            return (l1 + l2) * 2;
        }
    }
}
