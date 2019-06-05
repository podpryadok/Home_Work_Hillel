using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Создайте программу, которая будет выводить на экран цепочки падающих символов.
//Длина каждой цепочки задается случайно.
//Первый символ цепочки – белый, второй символ – светло-зеленый, остальные символы темно-зеленые.
//Во время падения цепочки, на каждом шаге, все символы меняют свое значение.
//Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка.
namespace Matrix
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
            while (true)
            {
                int length = random.Next(3, 6);
                int count = 0;
                for (int i = 0; i < 80; i++)
                {
                    Thread.Sleep(random.Next(20, 4000));
                    Console.CursorLeft = Otstup;
                    lock (locker)
                    {
                        Console.CursorTop = 0;
                        Console.ForegroundColor = ConsoleColor.Black;
                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = Otstup;
                            Console.WriteLine(" ");
                        }

                        if (count < length)
                        {
                            count++;
                        }
                        else if (count == length)
                        {
                            length = 0;
                        }
                        if (39 - i < count)
                        {
                            count--;
                        }

                        Console.CursorTop = i - count + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < count-2; j++)
                        {
                            Console.CursorLeft = Otstup;
                            ShowChar(RandomChar());
                        }
                        if (count >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Otstup;
                            ShowChar(RandomChar());
                        }
                        if (count >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Otstup;
                            ShowChar(RandomChar());
                        }
                    }
                    Thread.Sleep(random.Next(0,20));
                }
            }
        }
    }
}
