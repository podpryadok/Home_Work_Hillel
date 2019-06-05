using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton_Task_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Connect connect;
            connect = Connect.GetConnect("Connect123");
            Console.WriteLine(connect.Name);
            Connect connect1 = Connect.GetConnect("Connect321");
            Console.WriteLine(connect1.Name);

            Console.ReadLine();

        }
    }
}
