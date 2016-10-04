namespace MobilePhoneDevice
{
    using System.Text;

    public class Battery
    {
        #region Fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;
        #endregion

        #region Properties
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            var output = new StringBuilder();

            if (output == null)
            {
                output.AppendLine("No Batterino");
            }
            else
            {
                output.AppendLine(string.Format("Model: {0}", this.Model));
                output.AppendLine(string.Format("Battery Type: {0}", this.BatteryType));
                output.AppendLine(string.Format("Hours Idle: {0}", this.HoursIdle));
                output.AppendLine(string.Format("Hours Talk: {0}", this.HoursTalk));
            }
            return output.ToString();
        }
        #endregion

    }
}
