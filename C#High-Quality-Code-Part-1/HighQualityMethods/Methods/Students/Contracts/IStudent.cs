using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods.OtherInfo.Contracts;

namespace Methods.Students.Contracts
{
    public interface IStudent
    {
        /// <summary>
        /// Student's first name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Student's last name.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Contains birth place, birth date and a list of characteristics.
        /// </summary>
        IPersonalInformation OtherInfo { get; set; }
    }
}
