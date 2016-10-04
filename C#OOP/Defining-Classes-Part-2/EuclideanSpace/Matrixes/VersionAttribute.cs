namespace Matrixes
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | 
        AttributeTargets.Interface| AttributeTargets.Method | AttributeTargets.Enum)]

    public class VersionAttribute : Attribute
    {
        #region Constructors
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
        #endregion

        #region Properties
        public int Major { get; private set; }

        public int Minor { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Version {0}.{1}", this.Major, this.Minor);
        }
        #endregion
    }
}
