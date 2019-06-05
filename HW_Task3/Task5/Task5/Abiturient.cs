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
    class Abiturient
    {
        private string fulNameAbiturient;
        private string registretFacultet;
        private double midleScore;
        private bool changedExam;

        public string FulNameAbiturient { get => fulNameAbiturient; }
        public string RegistretFacultet { get => registretFacultet; }
        public double MidleScore { get => midleScore; }
        public bool ChangedExam { get => changedExam; }

        public Abiturient(string fullName)
        {
            fulNameAbiturient = fullName;
        }

        public void RegistretToFacultet(string facultet)
        {
            registretFacultet = facultet;
        }

        public void ChangeExam()
        {
            changedExam = true;
        }

        public double AddMidleScore(double score)
        {
            return midleScore = score;
        }
    }
}
