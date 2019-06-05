using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Требуется разработать многопоточное приложение.
//Приложение состоит из 4 потоков:•	“main” (главный поток): запускает потоки “inc”, “dec” и “print”. 
//Далее, поток постоянно (каждые 10 миллисекунд) проверяет значение переменной ACCOUNT и завершает процесс,
//если ACCOUNT вышел за границы диапазона[-10000, +10000].
//“inc” – поток время от времени(паузы выбираются случайным образом от 100 миллисекунд и до 3 секунд включительно)
//увеличивает значение переменной ACCOUNT на некоторую случайную величину(например от 1 до 100).
//“dec” – поток время от времени(паузы выбираются случайным образом от 100 миллисекунд и до 3 секунд включительно)
//уменьшает значение переменной ACCOUNT на некоторую случайную величину(например от 1 до 100).
//“print” – выводит на экран новое значение переменной ACCOUNT(как только оно изменилось). 
namespace AppForSrez
{

    class Account
    {
        Random random = new Random();
        public int ACCOUNT = 0;

        public delegate void Change(int Account);
        public event Change change;

        public void Inc()
        {
            while (true)
            {
                Thread.Sleep(random.Next(100, 3000));
                ACCOUNT = Interlocked.Add(ref ACCOUNT, random.Next(1, 100));
            }
        }

        public void Dec()
        {
            while (true)
            {
                Thread.Sleep(random.Next(100, 3000));
                ACCOUNT = Interlocked.Add(ref ACCOUNT, random.Next(1, 100));
            }
        }

        public void Print()
        {
            int prevVal = ACCOUNT;
            while (true)
            {
                if(prevVal != ACCOUNT)
                {
                    prevVal = ACCOUNT;
                    change(ACCOUNT);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            account.change += Account_change;
            bool onOff = true;

            Thread incThrad = new Thread(account.Inc);
            incThrad.Start();
            incThrad.IsBackground = true;

            Thread decThread = new Thread(account.Dec);
            decThread.Start();
            decThread.IsBackground = true;

            Thread printThread = new Thread(account.Print);
            printThread.Start();
            printThread.IsBackground = true;

            while (onOff)
            {
                if (account.ACCOUNT <= -1000 || account.ACCOUNT >= 1000)
                {
                    onOff = false;
                }
            }
        }

        private static void Account_change(int account)
        {
            Console.WriteLine(account);
        }
    }
}
