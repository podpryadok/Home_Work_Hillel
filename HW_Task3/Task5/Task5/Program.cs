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
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            ListPassed listPassed = new ListPassed();
            ListDidNotPass listDidNotPass = new ListDidNotPass();
            Abiturient abiturient1 = new Abiturient("Иванов И.");
            Abiturient abiturient2 = new Abiturient("Сидоров С.");

            abiturient1.RegistretToFacultet("Матиматики");
            abiturient1.ChangeExam();
            abiturient2.RegistretToFacultet("Физики");

            teacher.SetScore(abiturient1, listPassed, listDidNotPass);
            teacher.SetScore(abiturient2, listPassed, listDidNotPass);

            Console.ReadLine();

        }
    }
}
