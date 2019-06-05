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
    class ListDidNotPass
    {
        private List<Abiturient> didNotPass;

        public List<Abiturient> DidNotPass { get => didNotPass; }

        public ListDidNotPass()
        {
            didNotPass = new List<Abiturient>();
        }

        public void AddToDidNotPass(Abiturient abiturient)
        {
            didNotPass.Add(abiturient);
        }
    }
}
