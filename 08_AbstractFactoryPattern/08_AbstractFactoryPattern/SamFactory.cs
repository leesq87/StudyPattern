using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeAbstract;

namespace _08_AbstractFactoryPattern
{
    class SamFactory : IBikeFactory
    {
        public IBody createBody()
        {
            return new SamBody();
        }

        public IWheel createWheel()
        {
            return new SamWheel();
        }
    }
}
