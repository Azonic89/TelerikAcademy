namespace Cars.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class View : IView
    {
        public View(object model = null)
        {
            this.Model = model;
        }

        public object Model { get; private set; }
    }
}
