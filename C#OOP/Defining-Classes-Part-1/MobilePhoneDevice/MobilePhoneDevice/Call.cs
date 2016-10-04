namespace MobilePhoneDevice
{
    using System;

    public class Call
    {
        #region Fields
        private DateTime dateTime;
        #endregion

        #region Contructors
        public Call()
        {
            this.dateTime = DateTime.Now;
        }
        #endregion

        #region Properties
        public string Time
        {
            get
            {
                return this.dateTime.ToString("HH:mm:ss");
            }
        }

        public string Date
        {
            get
            {
                return this.dateTime.ToString("dd/MM/yyyy");
            }
        }

        public string DialedPhone { get; set; }

        public uint Duration { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Dialed: {0} - Duration : {1} - Date: {2}", this.DialedPhone, this.Duration, this.Date);
        }
        #endregion
    }
}
