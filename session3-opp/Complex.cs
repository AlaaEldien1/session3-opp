using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_opp
{
    internal class Complex
    {
        public int Real;
        public int Img;
        public Complex()
        {
            Real = 0;
            Img = 0;
        }
        public Complex(int real, int img)
        {
            this.Real = real;
            this.Img = img;
        }
        public  static  Complex operator +(Complex num1, Complex num2)
        {
            return new Complex(num1.Real + num2.Real , num1.Img + num2.Img);
        }

        public static Complex operator -(Complex num1, Complex num2)
        {
            return new Complex(num1.Real - num2.Real, num1.Img - num2.Img);
        }

        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }

    }
}
