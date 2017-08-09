using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeAbstract;

namespace _08_AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBikeFactory factory = new SamFactory();
            IBody body =  factory.createBody();
            IWheel wheel = factory.createWheel();

        }
    }
}
