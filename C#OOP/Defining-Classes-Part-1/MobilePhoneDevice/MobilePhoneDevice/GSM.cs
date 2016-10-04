namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        #region Fields
        private static GSM iphone4S;
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private BatteryType batteryType;
        private Display display;
        private List<Call> callHistory;
        
        #endregion

        #region Constructors 
        static GSM()
        {
            iphone4S = new GSM(
                "iPhone 4S",
                "Apple", 1000.0m,
                "Stamat",
                new Battery() {Model = "Iphone Battery Yo!", HoursIdle = 76, HoursTalk = 15 },
                new Display() { Size = 4, NumberOfColors = 16000000 },
                BatteryType.OEM);
        }
        public GSM(string model, string manufacturer,decimal? price = null, string owner = null)
            : this(model, manufacturer)
        {

        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, owner)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display, BatteryType batteryType)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
            this.BatteryType = batteryType;
        }

        #endregion

        #region Properties
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
        public static GSM Iphone4S { get { return iphone4S; } }

        public Display Display
        {
            get { return this.display; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Display cannot be  null or empty value!!!");
                }
                this.display = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Battery cannot be  null or empty value!!!");
                }
                this.battery = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner cannot be  null or empty value!!!");
                }

                this.owner = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Price cannot be  null or empty value!!!");
                }

                this.price = value;
            }
        }

        public string Model     
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be  null or empty value!!!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be null or empty value!!!");
                }

                this.manufacturer = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                if (this.callHistory == null)
                {
                    this.callHistory = new List<Call>();
                }

                this.callHistory.Clear();
                this.callHistory = value;
            }
        }

        #endregion

        #region Methods
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalCost(decimal fixedPrice)
        {
            ulong totalDuration = 0;
            foreach (Call call in this.callHistory)
            {
                totalDuration += (ulong)call.Duration;
            }

            return fixedPrice * (decimal)(totalDuration / 60);
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine(string.Format("Model: {0}", this.Model));
            output.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            output.AppendLine(string.Format("Price: {0}", this.Price));
            output.AppendLine(string.Format("Owner: {0}", this.Owner));
            output.AppendLine(string.Format("Battery: {0}", this.Battery));
            output.AppendLine(string.Format("Display: {0}", this.Display));
           
            return output.ToString();
        }


        #endregion

    }
}
