namespace AbstractFactoryExample.Models.Abstract
{
    using System;

    public abstract class Pet
    {
        protected Pet(string breed, string color, string gender)
        {
            this.Breed = breed;
            this.Color = color;
            this.Gender = gender;
        }

        public string Breed { get; }

        public string Color { get; }

        public string Gender { get; }

        public override string ToString()
        {
            return $"Breed: {this.Breed} {Environment.NewLine}" +
                   $"Color: {this.Color} {Environment.NewLine}" +
                   $"Gender: {this.Gender} {Environment.NewLine}";
        }
    }
}
