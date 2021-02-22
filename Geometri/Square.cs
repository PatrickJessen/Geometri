using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Square
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public Square()
        {

        }

        public int CalculateCircumference()
        {
            return Side * 4;
        }

        public int CalculateArial()
        {
            return Side * Side;
        }
    }
}
