//Создать класс, представляющий учебный класс ClassRoom.
//Создайте класс ученик Pupil.В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil 
//и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

namespace Task2
{
    class Pupil
    {
        private string name;
        private int stading;
        private int reding;
        private int writing;
        private int relaxing;

        public int Relaxing { get => relaxing; }
        public int Writing { get => writing; }
        public int Reding { get => reding; }
        public int Stading { get => stading; }
        public string Name { get => name; }

        public Pupil(string name)
        {
            this.name = name;
        }
        public virtual void Study(int ocenka)
        {
            stading = ocenka;
        }

        public virtual void Read(int ocenka)
        {
            reding = ocenka;
        }

        public virtual void Write(int ocenka)
        {
            writing = ocenka;
        }

        public virtual void Relax(int ocenka)
        {
            relaxing = ocenka;
        }
    }

    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name)
        {
        }

        public override void Study(int ocenka)
        {
            base.Study(ocenka);
        }

        public override void Read(int ocenka)
        {
            base.Read(ocenka);
        }

        public override void Write(int ocenka)
        {
            base.Write(ocenka);
        }

        public override void Relax(int ocenka)
        {
            base.Relax(ocenka);
        }
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        {
        }

        public override void Study(int ocenka)
        {
            base.Study(ocenka);
        }

        public override void Read(int ocenka)
        {
            base.Read(ocenka);
        }

        public override void Write(int ocenka)
        {
            base.Write(ocenka);
        }

        public override void Relax(int ocenka)
        {
            base.Relax(ocenka);
        }
    }

    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        {
        }

        public override void Study(int ocenka)
        {
            base.Study(ocenka);
        }

        public override void Read(int ocenka)
        {
            base.Read(ocenka);
        }

        public override void Write(int ocenka)
        {
            base.Write(ocenka);
        }

        public override void Relax(int ocenka)
        {
            base.Relax(ocenka);
        }
    }
}
