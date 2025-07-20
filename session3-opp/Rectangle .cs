using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_opp
{
    internal class Rectangle
    {
        public int width;
        public int height;
        public Rectangle ()
        {
            width = 0;
            height = 0;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int input )
        {
            this.width = input;
            this.height = input;
        }
    }
}
