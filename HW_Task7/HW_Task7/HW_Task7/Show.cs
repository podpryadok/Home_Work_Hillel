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
    class Show
    {
        public static void show(AbstractHandler abstractHandler, string fileAdres)
        {
            string comand = string.Empty;

            while (true)
            {
                Console.Write("Введите команду - open или create: ");
                comand = Console.ReadLine();
                if (comand == "open")
                {
                    abstractHandler.Open(fileAdres);

                    while (true)
                    {
                        Console.WriteLine("Введите команду - read, change или save");
                        comand = Console.ReadLine();
                        if (comand == "read")
                        {
                            
                            abstractHandler.Reader(abstractHandler.file, fileAdres);

                        }
                        else if (comand == "change")
                        {
                            abstractHandler.Change(abstractHandler.file, fileAdres);

                        }
                        else if (comand == "save")
                        {
                            abstractHandler.Save(abstractHandler.file);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимая команда. Попробуйте снова=)");
                        }
                    }
                    break;
                }
                else if (comand == "create")
                {
                    abstractHandler.Create(fileAdres);

                    while (true)
                    {
                        Console.WriteLine("Введите команду - read, change или save");
                        comand = Console.ReadLine();
                        if (comand == "read")
                        {
                            abstractHandler.Reader(abstractHandler.file, fileAdres);

                        }
                        else if (comand == "change")
                        {
                            abstractHandler.Change(abstractHandler.file, fileAdres);

                        }
                        else if (comand == "save")
                        {
                            abstractHandler.Save(abstractHandler.file);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не допустимая команда. Попробуйте снова=)");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Не допустимая команда. Попробуйте снова=)");
                }
            }
        }
    }
}
