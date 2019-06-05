using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40); //Устанавливаем размеры окна консоли

            for (int i = 0; i < 30; i++)
            {
                Matrix matrix = new Matrix(i * 2);
                new Thread(matrix.Move).Start();
            }
        }
    }
}
