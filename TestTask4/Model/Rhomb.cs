using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask4.Model
{
    internal class Rhomb : Rectangle
    {
        private int a;
        public Rhomb(int hight, int width) : base(hight, width)
        {
            a = (int)(Math.Sqrt(hight * hight + width * width) / 2);
        }
        public override int GetPerimeter()
        {
            return a*4;
        }
        public override bool CanBe()
        {
            if (base.CanBe() && a > 0)
            {
                return true;
            }
            return false;
        }
    }
}
