using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask4.Model
{
    public class Rectangle : IFigure
    {
        public int Hight { get; set; }
        public int Width { get; set; }

        public Rectangle(int hight, int width)
        {
            Hight = hight;
            Width = width;
        }

        public virtual bool CanBe()
        {
            if (Hight > 0 && Width > 0)
            {
                return true;
            }
            return false;
        }

        public virtual int GetPerimeter()
        {
            return Hight * 2 + Width * 2; 
        }

        public virtual int GetSquare()
        {
            return Hight * Width;
        }
    }
}
