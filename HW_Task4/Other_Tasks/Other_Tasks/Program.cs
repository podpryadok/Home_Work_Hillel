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
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil("Semen");
            BadPupil badPupil = new BadPupil("Stas");
            GoodPupil goodPupil = new GoodPupil("Leha");
            GoodPupil goodPupil2 = new GoodPupil("Vasya");

            goodPupil.Study(4);
            goodPupil.Read(4);
            goodPupil.Write(4);
            goodPupil.Relax(3);

            goodPupil2.Study(4);
            goodPupil2.Read(4);
            goodPupil2.Write(4);
            goodPupil2.Relax(3);

            excelentPupil.Study(5);
            excelentPupil.Read(5);
            excelentPupil.Write(5);
            excelentPupil.Relax(2);

            badPupil.Study(2);
            badPupil.Read(2);
            badPupil.Write(2);
            badPupil.Relax(5);

            ClassRoom classRoom = new ClassRoom(goodPupil, goodPupil2, badPupil);
            classRoom.pupilsClass.Add(excelentPupil);
            classRoom.Show();
            Console.ReadLine();
        }
    }
}
