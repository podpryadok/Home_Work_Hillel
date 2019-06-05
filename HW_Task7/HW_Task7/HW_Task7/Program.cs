using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс AbstractHandler.
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, 
//создания, редактирования, сохранения определенного формата документа.
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите аддрес файла: ");
            string fileAdres = Console.ReadLine();
            

            string format = fileAdres.Substring(fileAdres.Length - 3);

            if (format == "txt")
            {
                TXTHandler tXTHandler = new TXTHandler();
                Show.show(tXTHandler, fileAdres);
            }

            if (format == "xml")
            {
                XMLHandler xMLHandler = new XMLHandler();
                Show.show(xMLHandler, fileAdres);
            }

            if (format == "doc")
            {
                DOCHandler dOCHandler = new DOCHandler();
                Show.show(dOCHandler, fileAdres);
            }

        }
    }
}
