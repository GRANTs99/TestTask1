using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask4.Model
{
    internal class Square : Rectangle
    {
        public Square(int hight, int width) : base(hight, width)
        {

        }

        public override bool CanBe()
        {
            if (base.CanBe() && Width == Hight)
            {
                return true;
            }
            return false;
        }
    }
}
