namespace FacadeExample.Models
{
    using System;

    public class RemoteController
    {
        public void DimLights(int amount)
        {
            var desiredAmmount = amount;
            if (desiredAmmount < 0)
            {
                desiredAmmount = 0;
            }

            if (desiredAmmount > 100)
            {
                desiredAmmount = 100;
            }

            Console.WriteLine($"Dimming lights to {desiredAmmount}...");
        }

        public void MoveCurtains(int amount)
        {
            var desiredAmmount = amount;
            if (desiredAmmount < 0)
            {
                desiredAmmount = 0;
            }

            if (desiredAmmount > 100)
            {
                desiredAmmount = 100;
            }

            Console.WriteLine($"Moving curtains to {desiredAmmount} percent...");
        }

        public void HideTable()
        {
            Console.WriteLine("Hiding the table...");
        }
    }
}
