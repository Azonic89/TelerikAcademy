namespace MobilePhoneDevice
{
    using System.Text;

    public class Display
    {
        #region Fields
        private double size;
        private ulong numberOfColors;
        #endregion

        #region Properties
        public ulong NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("Size: {0}", this.Size));
            result.AppendLine(string.Format("Number of Colors: {0}", this.NumberOfColors));

            return result.ToString();
        }
        #endregion
    }
}
