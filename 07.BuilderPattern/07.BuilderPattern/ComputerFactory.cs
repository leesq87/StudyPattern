using System;

namespace _07.BuilderPattern
{
    internal class ComputerFactory
    {

        private Blueprint print;

        public void SetBlueprint(Blueprint print)
        {
            this.print = print;
        }


        internal void Make()
        {
            print.SetCpu();
            print.SetRam();
            print.SetStorage();
        }

        internal Computer GetComputer()
        {
            return print.getComputer();
        }
    }
}