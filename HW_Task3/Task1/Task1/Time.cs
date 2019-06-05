//Составить описание класса для представления времени.
//Предусмотреть возможности установки времени 
//и изменения его отдельных полей (час, минута, секунда) с проверкой допустимости вводимых значений.
//В случае недопустимых значений полей выбрасываются исключения.
//Создать методы изменения времени на заданное количество часов, минут и секунд.
namespace Task1
{
    class Time
    {
        private byte hours;
        private byte minutes;
        private byte seconds;

        public byte Hours { get => hours; }
        public byte Minutes { get => minutes; }
        public byte Seconds { get => seconds; }

        public Time()
        {
           hours = 24;
           minutes = 00;
           seconds = 00;
        }

        public void SetHours(byte hours)
        {
            if(hours <= 24 && hours > 0)
            {
                this.hours = hours;
            }
            else { System.Console.WriteLine("Введёно недопустимое значение!"); }
        }

        public void SetMinutes(byte minutes)
        {
            if (minutes <= 60 && minutes > 0)
            {
                this.minutes = minutes;
            }
            else { System.Console.WriteLine("Введёно недопустимое значение!"); }
        }

        public void SetSeconds(byte seconds)
        {
            if (seconds <= 60 && seconds > 0)
            {
                this.seconds = seconds;
            }
            else { System.Console.WriteLine("Введёно недопустимое значение!"); }
        }

        public void Show()
        {
            System.Console.WriteLine($"Сейчас установлено: {hours}:{minutes}:{seconds}");
        }
    }
}
