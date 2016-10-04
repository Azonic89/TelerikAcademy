using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Groupnumber cannot be a null value!");
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        public string DepartmentName
        {
            get { return this.departmentName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Department Name cannot be a null value!");
                }
                else
                {
                    this.departmentName = value;
                }
            }
        }
    }
}
