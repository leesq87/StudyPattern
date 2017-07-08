using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IAdapter
    {
        float TwiceOf(float f);
        float HalfOf(float f);
    }
}
