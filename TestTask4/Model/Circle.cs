using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask4.Model
{
    public class Circle : IFigure
    {
        public int Hight { get; set; }
        public int Width { get; set; }
        public int Radius { get; set; }

        public Circle(int hight, int width)
        {
            Hight = hight;
            Width = width;
            Radius = width / 2;
        }
        public Circle(int radius)
        {
            Radius = radius;
            Width = radius * 2;
            Hight = Width;
        }


        public bool CanBe()
        {
            if(Hight > 0 && Hight == Width)
            {
                return true;
            }
            return false;
        }

        public int GetPerimeter()
        {
            return Radius * 6;
        }

        public int GetSquare()
        {
            return Radius * Radius * 3;
        }
    }
}
