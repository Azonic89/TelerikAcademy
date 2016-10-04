namespace TimerDelegate
{
    using System;

    public class TimerRunTest
    {
        public static void Run()
        {
            Console.WriteLine("Timer test below: WAIT FOR IT :D ");
            Console.WriteLine("---------------------------------");
            Timer timer = new Timer(Timer.Print, 5, 1500);
            timer.TimerExecute();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Timer Ended!!!");
        }
    }
}
