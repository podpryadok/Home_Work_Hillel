using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2
{
    class Matrix
    {
        Random random = new Random((int)DateTime.Now.Ticks);
        static readonly object locker = new object();
        private int Otstup;
        public Matrix(int ots)
        {
            Otstup = ots;
        }
        public char RandomChar()
        {
            string simbol = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            char result;
            result = simbol[random.Next(0, simbol.Length)];
            return result;
        }

        private void ShowChar(char ch)
        {
            Console.WriteLine(ch);
        }

        public void Move()
        {

        }
    }
}
