namespace PersonGenerator.Entities
{
    using Enums;

    internal class Person
    {
        public Person(int age)
        {
            this.Age = age;

            var even = age % 2 == 0;

            if (even)
            {
                this.Name = NameType.Pesho;
                this.Gender = GenderType.Male;
            }
            else
            {
                this.Name = NameType.Goshka;
                this.Gender = GenderType.Female;
            }
        }

        public NameType Name { get; set; }

        public GenderType Gender { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(this.Name)}: {this.Name}, {nameof(this.Age)}: {this.Age}, {nameof(this.Gender)}: {this.Gender}!";
        }
    }
}
