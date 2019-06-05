using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton_Task_4_
{
    class Connect
    {
        private static Connect connect;
        private string name = string.Empty;

        private Connect(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public static Connect GetConnect(string name)
        {
            if(connect == null)
            {
                connect = new Connect(name);
            }
            return connect;
        }
    }
}
