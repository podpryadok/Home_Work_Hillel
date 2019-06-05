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
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40); //Устанавливаем размеры окна консоли

            for (int i = 0; i < 30; i++)
            {
                Matrix matrix = new Matrix(i*2);
                new Thread(matrix.Move).Start();
            }
        }
    }
}
