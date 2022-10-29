using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask4.Model
{
    public interface IFigure
    {
        public int Hight { get; set; }
        public int Width { get; set; }
        public int GetPerimeter();
        public int GetSquare();
        public bool CanBe();
    }
}
