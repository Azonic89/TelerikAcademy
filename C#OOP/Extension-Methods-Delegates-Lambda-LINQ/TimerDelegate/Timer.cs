namespace TimerDelegate
{
    using System;
    using System.Threading;

    public delegate void SampleDelegate();

    public class Timer
    {
        private int timesOfExecute;
        private int intervalOfMilliseconds;
        private SampleDelegate timerDelegate;

        public Timer(SampleDelegate timerDelegate, int timesOfExecute, int intervalOfMilliseconds)
        {
            this.TimerDelegate = timerDelegate;
            this.TimesOfExecute = timesOfExecute;
            this.IntervalOfMilliseconds = intervalOfMilliseconds;

        }

        public int TimesOfExecute
        {
            get
            {
                return this.timesOfExecute;
            }
            set
            {
                this.timesOfExecute = value;
            }
        }

        public int IntervalOfMilliseconds
        {
            get
            {
                return this.intervalOfMilliseconds;
            }
            set
            {
                this.intervalOfMilliseconds = value;
            }
        }

        public SampleDelegate TimerDelegate
        {
            get
            {
                return this.timerDelegate;
            }
            set
            {
                this.timerDelegate = value;
            }
        }

        public void TimerExecute()
        {
            for (int i = 0; i < TimesOfExecute; i++)
            {
                Thread.Sleep(IntervalOfMilliseconds);
                TimerDelegate();
            }
        }

        public static void Print()
        {
            Console.WriteLine("Hello There Young one !!!");
        }
    }    
}
