using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Составить описание класса для представления времени.
//Предусмотреть возможности установки времени 
//и изменения его отдельных полей (час, минута, секунда) с проверкой допустимости вводимых значений.
//В случае недопустимых значений полей выбрасываются исключения.
//Создать методы изменения времени на заданное количество часов, минут и секунд.
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();

            time.Show();
            bool a = true;
            byte userByte = 0;

            while (a)
            {
                Console.WriteLine("Выберете что будете изменять Hour, Minutes или Seconds:");
                string userTime = Console.ReadLine();
                if (userTime == "Hour" || userTime == "Minutes" || userTime == "Seconds")
                {
                    Console.WriteLine("Введите значение:");
                    try
                    {
                        userByte = Convert.ToByte(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }
                }

                switch (userTime)
                {
                    case "Hour":
                        time.SetHours(userByte);
                        //a = false;
                        break;
                    case "Minutes":
                        time.SetMinutes(userByte);
                       // a = false;
                        break;
                    case "Seconds":
                        time.SetSeconds(userByte);
                       //a = false;
                        break;
                    default:
                        Console.WriteLine("Команда введена не правильно!");
                        break;
                }
                time.Show();
                Console.WriteLine("________");
            }
            
        }
    }
}
