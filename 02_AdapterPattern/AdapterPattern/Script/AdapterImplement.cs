using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class AdapterImplement : IAdapter
    {
        //Math math = new Math();

        public float HalfOf(float f)
        {
            return (float)Math.half(f);
        }

        public float TwiceOf(float f)
        {
            Console.WriteLine("called");

            return (float)Math.TwoTime(f);
        }
    }
}
