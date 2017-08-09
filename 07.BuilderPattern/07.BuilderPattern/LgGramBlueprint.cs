using System;

namespace _07.BuilderPattern
{
    internal class LgGramBlueprint :Blueprint
    {

        private Computer computer;


        public LgGramBlueprint()
        {
            computer = new Computer("default", "default", "default");
        }


        public override void SetCpu()
        {
            computer.Cpu = "i7";
        }

        public override void SetRam()
        {
            computer.Ram = "8g";
        }

        public override void SetStorage()
        {
            computer.Storage = "256g ssd";
        }

        internal override Computer getComputer()
        {
            return computer;
        }
    }
}