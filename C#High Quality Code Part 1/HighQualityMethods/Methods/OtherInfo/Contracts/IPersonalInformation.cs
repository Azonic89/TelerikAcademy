using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.OtherInfo.Contracts
{
    public interface IPersonalInformation
    {
        /// <summary>
        /// Place of birth.
        /// </summary>
        string Birthplace { get; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        DateTime BirthDate { get; }

        /// <summary>
        /// Comma separated list of a person's characteristics.
        /// </summary>
        string Characteristics { get; }
    }
}
