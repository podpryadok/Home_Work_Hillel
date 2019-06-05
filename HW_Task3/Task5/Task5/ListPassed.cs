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
    class ListPassed
    {
        private List<Abiturient> passed;

        public List<Abiturient> Passed { get => passed; }

        public ListPassed()
        {
            passed = new List<Abiturient>();
        }

        public void AddToPassed(Abiturient abiturient)
        {
            passed.Add(abiturient);
        }
    }
}
