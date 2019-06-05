using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Создайте класс AbstractHandler.
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, 
//создания, редактирования, сохранения определенного формата документа.
namespace Task1
{
    abstract class AbstractHandler
    {
        public abstract FileStream Open(string fileAdres);
        public abstract FileStream Create(string fileAdres);
        public abstract void Change(FileStream file, string fileAdres);
        public abstract void Save(FileStream file);
        public abstract void Reader(FileStream file, string fileAdres);

        public FileStream file;
    }

    class XMLHandler : AbstractHandler
    {
        

        public override void Change(FileStream file, string fileAdres)
        {
            StreamWriter writer = new StreamWriter(fileAdres);
            Console.WriteLine("Введите новые данные: ");
            writer.Write(Console.ReadLine());
            writer.Close();
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
        }

        public override FileStream Create(string fileAdres)
        {
            base.file = new FileStream(fileAdres, FileMode.CreateNew, FileAccess.ReadWrite);
            Console.WriteLine("Файл создан. Выберите следующую команду - Read, Change, Save.");
            return file;
        }

        public override FileStream Open(string fileAdres)
        {
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
            Console.WriteLine("Файл открыт. Выберите следующую команду - Read, Change, Save.");
            return file;
        }

        public override void Reader(FileStream file, string fileAdres)
        {
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
        }

        public override void Save(FileStream file)
        {
            file.Dispose();
            file.Close();
        }
    }

    class TXTHandler : AbstractHandler
    {


        public override void Change(FileStream file, string fileAdres)
        {
            StreamWriter writer = new StreamWriter(file);
            Console.WriteLine("Введите новые данные: ");
            writer.Write(Console.ReadLine());
            writer.Close();
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
        }

        public override FileStream Create(string fileAdres)
        {
            base.file = new FileStream(fileAdres, FileMode.CreateNew, FileAccess.ReadWrite);
            Console.WriteLine("Файл создан. Выберите следующую команду - Read, Change, Save.");
            return file;
        }

        public override FileStream Open(string fileAdres)
        {
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
            Console.WriteLine("Файл открыт. Выберите следующую команду - Read, Change, Save.");
            return file;
        }

        public override void Reader(FileStream file, string fileAdres)
        {
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
        }

        public override void Save(FileStream file)
        {
            base.file.Dispose();
            base.file.Close();
        }
    }

    class DOCHandler : AbstractHandler
    {

        public override void Change(FileStream file, string fileAdres)
        {
            StreamWriter writer = new StreamWriter(file);
            Console.WriteLine("Введите новые данные: ");
            writer.Write(Console.ReadLine());
            writer.Close();
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
        }

        public override FileStream Create(string fileAdres)
        {
            base.file = new FileStream(fileAdres, FileMode.CreateNew, FileAccess.ReadWrite);
            Console.WriteLine("Файл создан. Выберите следующую команду - Read, Change, Save.");
            return file;
        }

        public override FileStream Open(string fileAdres)
        {
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
            Console.WriteLine("Файл открыт. Выберите следующую команду - Read, Change, Save.");
            return file;
        }

        public override void Reader(FileStream file, string fileAdres)
        {
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            base.file = new FileStream(fileAdres, FileMode.Open, FileAccess.ReadWrite);
        }

        public override void Save(FileStream file)
        {
            base.file.Dispose();
            base.file.Close();
        }
    }
}
