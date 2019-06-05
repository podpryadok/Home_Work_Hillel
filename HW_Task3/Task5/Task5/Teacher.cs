using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Разработать систему «Вступительные экзамены». 
//Абитуриент регистрируется на Факультет, сдает Экзамены.
//Преподаватель выставляет Оценку.
//Система подсчитывает средний бал и определяет Абитуриента, зачисленного в учебное заведение.
namespace Task5
{
    class Teacher
    {
        public void SetScore(Abiturient abiturient, ListPassed passed, ListDidNotPass didNotPass)
        {
            if (abiturient.RegistretFacultet != null)
            {
                if (abiturient.ChangedExam)
                {
                    Console.WriteLine("Введите бал за алгебру:");
                    double algebra = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите бал за историю:");
                    double history = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите бал за английский язык:");
                    double english = Convert.ToInt32(Console.ReadLine());
                    abiturient.AddMidleScore((algebra + history + english) / 3);
                    if(abiturient.MidleScore >= 70)
                    {
                        passed.AddToPassed(abiturient);
                    }
                    else
                    {
                        didNotPass.AddToDidNotPass(abiturient);
                    }
                }
                else
                {
                    Console.WriteLine("Этот абитуриент еще не сдал экзамены.");
                }
            }
            else
            {
                Console.WriteLine("Абитуриент еще не выбрал факультет!");
            }
        }
    }
}
