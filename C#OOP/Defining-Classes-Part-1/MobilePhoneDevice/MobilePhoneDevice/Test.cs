namespace MobilePhoneDevice
{
    using System;

    public class Test
    {
        static void Main()
        {
            var gsm = new GSM("Samsung", "S7 Edge+", 1200.0m, "Stamat", new Battery { Model = "G1567", HoursIdle = 78, HoursTalk = 20, }, new Display {Size = 5.4, NumberOfColors = 64000000 }, BatteryType.NiCd);
            gsm.CallHistory.Add(new Call() { Duration = 1000, DialedPhone = "+359********9" });

            for (int i = 0; i < 10; i++)
            {
                gsm.AddCall(new Call()
                {
                    DialedPhone = "+359********" + i,
                    Duration = (uint)(i + 1) * 120
                });
            }

            var maxCall = new Call();
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
                if (maxCall.Duration < call.Duration)
                    maxCall = call;
            }

            Console.WriteLine("Total calls: {0}",gsm.CalculateTotalCost(0.37m));
            gsm.DeleteCall(maxCall);
            Console.WriteLine("Total calls without Longest Call: {0}", gsm.CalculateTotalCost(0.37m));

            Console.WriteLine(gsm.ToString());

            Console.WriteLine(GSM.Iphone4S); 

            
            
        }
    }
}
