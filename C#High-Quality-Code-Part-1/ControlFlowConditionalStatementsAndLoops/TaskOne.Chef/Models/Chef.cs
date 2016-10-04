namespace TaskOne.Chef.Models
{
    using Contracts;
    using Vegetables;

    public class Chef
    {
        private ITalk speachLog;

        public Chef(string name)
        {
            this.ChefName = name;
            this.speachLog = new Speach();
        }

        public string ChefName { get; set; }

        public void Introduce()
        {
            var message = $"Hello, my name is {this.ChefName} and I am a super Duper Cook Master Chef Yo";

            this.speachLog.Say(message);
        }

        public IContainable GetBowl()
        {
            var bowl = new Bowl();
            this.speachLog.Say("Bowl Present Now Young ONE!");

            return bowl;
        }

        public IVegetable GetCarrot()
        {
            var carrot = new Carrot();
            this.speachLog.Say("Carrot Nom Nom!");

            return carrot;
        }

        public IVegetable GetPotato()
        {
            var potato = new Potato();
            this.speachLog.Say("Potato Nom Nom!");

            return potato;
        }

        public void Cut(IVegetable vegetable)
        {
            vegetable.IsCut = true;
            this.speachLog.Say("Peeling Done Young Awesome One!!!");
        }

        public void Peel(IVegetable vegetable)
        {
            vegetable.IsPeeled = true;
            this.speachLog.Say("Peeling Done Young Awesome One!!!");
        }

        public void Cook(IVegetable firstVegetable, IVegetable secondVegetable, IContainable bowl)
        {
            var areIngridientsAvaliable = (firstVegetable != null) && (secondVegetable != null) && (bowl != null);

            if (!areIngridientsAvaliable)
            {
                this.speachLog.Say("Oops, bad stuff happened with the ingredients!");
                return;
            }

            this.PrepareVegetables(firstVegetable, secondVegetable);

            var isPreparationComplete = this.CheckIfVegetableIsReadyToCook(firstVegetable)
                && this.CheckIfVegetableIsReadyToCook(secondVegetable);

            if (isPreparationComplete)
            {
                bowl.Contents.Add(secondVegetable);
                bowl.Contents.Add(firstVegetable);

                this.speachLog.Say("Awesome we got ourselves vegetables in a bowl!");
            }
            else
            {
                this.speachLog.Say("Oops, We Messed Up Brah!");
            }
        }

        private void PrepareVegetables(IVegetable firstVegetable, IVegetable secondVegetable)
        {
            this.Peel(firstVegetable);
            this.Peel(firstVegetable);

            this.Cut(secondVegetable);
            this.Cut(secondVegetable);
        }

        private bool CheckIfVegetableIsReadyToCook(IVegetable vegetable)
        {
            var isReady = vegetable.IsPeeled && vegetable.IsCut && !vegetable.IsRotten;

            return isReady;
        }
    }
}
