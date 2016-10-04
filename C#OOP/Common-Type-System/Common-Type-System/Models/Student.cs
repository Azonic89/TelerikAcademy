namespace Common_Type_System.Models
{
    using Enumerations;
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string permanentAdddress;
        private string mobilePhone;
        private string email;
        private byte course;
        private SpecialityType specialityType;
        private UniversityType universityType;
        private FacultyType facultyType;

        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress, string mobilePhone, 
            string email, byte course, SpecialityType specialityType, UniversityType universityType, FacultyType facultyType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.SpecialityType = specialityType;
            this.UniversityType = universityType;
            this.FacultyType = facultyType;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }

        public int Ssn
        {
            get { return this.ssn; }
            set
            {
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAdddress; }
            set
            {
                this.permanentAdddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;
            }
        }

        public byte Course
        {
            get { return this.course; }
            set
            {
                this.course = value;
            }
        }

        public SpecialityType SpecialityType
        {
            get { return this.specialityType; }
            set
            {
                this.specialityType = value;
            }
        }

        public UniversityType UniversityType
        {
            get { return this.universityType; }
            set
            {
                this.universityType = value;
            }
        }

        public FacultyType FacultyType
        {
            get { return this.facultyType; }
            set
            {
                this.facultyType = value;
            }
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }
            if (student.FirstName == this.FirstName && student.MiddleName == this.MiddleName && student.LastName == this.LastName && student.Ssn == this.Ssn 
                && student.PermanentAddress == this.PermanentAddress && student.MobilePhone == this.MobilePhone && student.Email == this.Email 
                && student.Course == this.Course && student.SpecialityType == this.SpecialityType && student.UniversityType == this.UniversityType 
                && student.FacultyType == this.FacultyType)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine("First Name: " + this.FirstName);
            output.AppendLine("Middle Name: " + this.MiddleName);
            output.AppendLine("Last Name: " + this.LastName);
            output.AppendLine("SSN: " + this.Ssn);
            output.AppendLine("Permanent Address: " + this.PermanentAddress);
            output.AppendLine("Mobile Phone: " + this.MobilePhone);
            output.AppendLine("E-mail: " + this.Email);
            output.AppendLine("Course: " + this.Course);
            output.AppendLine("Speciality: " + this.SpecialityType);
            output.AppendLine("University: " + this.UniversityType);
            output.AppendLine("Faculty: " + this.FacultyType);
          
            return output.ToString();
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ Ssn.GetHashCode();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName,
                this.LastName, this.Ssn, this.PermanentAddress, 
                this.MobilePhone, this.Email, this.Course, 
                this.SpecialityType, this.UniversityType, this.FacultyType);

            return result;
        }

        public int CompareTo(Student currentStudent)
        {
            int firstNameComp = this.FirstName.CompareTo(currentStudent.FirstName);
            int middleNameComp = this.MiddleName.CompareTo(currentStudent.MiddleName);
            int lastNameComp = this.LastName.CompareTo(currentStudent.LastName);
            int SSNComp = this.Ssn.CompareTo(currentStudent.Ssn);

            if (firstNameComp != 0)
            {
                return firstNameComp;
            }
            else if (middleNameComp != 0)
            {
                return middleNameComp;
            }
            else if (lastNameComp != 0)
            {
                return lastNameComp;
            }
            else if (SSNComp != 0)
            {
                return SSNComp;
            }
            else
            {
                return 0;
            }
        }
    }
}
