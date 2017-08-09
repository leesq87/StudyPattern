using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PtototypePattern
{
    public class Circle : Shape
    {
        private int x,y,r;

        public Circle (int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public int R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Circle copy()
        {
            Circle circle = (Circle)MemberwiseClone();
            circle.x += 1;
            circle.y += 1;

            return circle;
        }
    }
}
