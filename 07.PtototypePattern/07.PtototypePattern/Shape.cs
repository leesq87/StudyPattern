using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PtototypePattern
{
    public class Shape : ICloneable
    {
        private string id;

        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetId(string id)
        {
            return id;
        }


        public object Clone()
        {
            object obj = (object)MemberwiseClone();
            return obj;
        }
    }
}
