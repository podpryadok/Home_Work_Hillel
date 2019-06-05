using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать класс, представляющий учебный класс ClassRoom.
//Создайте класс ученик Pupil.В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil 
//и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

namespace Task2
{
    class ClassRoom
    {
        public List<Pupil> pupilsClass;

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupilsClass = new List<Pupil>(4);
            pupilsClass.Add(pupil1);
            pupilsClass.Add(pupil2);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupilsClass = new List<Pupil>(4);
            pupilsClass.Add(pupil1);
            pupilsClass.Add(pupil2);
            pupilsClass.Add(pupil3);
        }

        public void Show()
        {
            foreach(var p in pupilsClass)
            {
                Console.WriteLine($"Имя:{p.Name}- учится:{p.Stading}, читает:{p.Reding}, пишет:{p.Writing}, отдыхает:{p.Relaxing}");
            }
        }
    }
}
