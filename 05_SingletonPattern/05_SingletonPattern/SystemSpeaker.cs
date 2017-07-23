using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SingletonPattern
{
    public class SystemSpeaker
    {
        static private SystemSpeaker _instnace;

        private int volume;


        private SystemSpeaker()
        {
            volume = 5;
        }

        public static SystemSpeaker GetInstance()
        {
            if(_instnace == null)
            {
                _instnace = new SystemSpeaker();
            }

            return _instnace;
        }

        public int GetVolume()
        {
            return volume;
        }
          
        public void SetVolume(int volume)
        {
            this.volume = volume;
        }
    }
}
