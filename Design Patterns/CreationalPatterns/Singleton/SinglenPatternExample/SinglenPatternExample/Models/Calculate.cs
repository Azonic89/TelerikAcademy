namespace SinglenPatternExample.Models
{
    public class Calculate
    {
        private static Calculate instance = null;

        private Calculate()
        {
        }
 
        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculate();
                }

                return instance;
            }
        }

        public double ValueOne { get; set; }

        public double ValueTwo { get; set; }

        public double Addition()
        {
            return this.ValueOne + this.ValueTwo;
        }

        public double Subtraction()
        {
            return this.ValueOne - this.ValueTwo;
        }

        public double Multiplication()
        {
            return this.ValueOne * this.ValueTwo;
        }

        public double Division()
        {
            return this.ValueOne / this.ValueTwo;
        }
    }
}
