using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BuilderPattern
{
    public class Computer
    {
        private string cpu;
        private string ram;
        private string storage;

        public Computer(string cpu, string ram, string storage)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.storage = storage;
        }

        public string Cpu
        {
            get
            {
                return cpu;
            }

            set
            {
                cpu = value;
            }
        }

        public string Ram
        {
            get
            {
                return ram;
            }

            set
            {
                ram = value;
            }
        }

        public string Storage
        {
            get
            {
                return storage;
            }

            set
            {
                storage = value;
            }
        }


        public override string ToString()
        {
            return cpu + "," + ram + "," + storage;
        }

    }
}
