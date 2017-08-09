using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BuilderPattern
{
    public abstract class Blueprint
    {
        public abstract void SetCpu();
        public abstract void SetRam();
        public abstract void SetStorage();
        internal abstract Computer getComputer();
    }
}
