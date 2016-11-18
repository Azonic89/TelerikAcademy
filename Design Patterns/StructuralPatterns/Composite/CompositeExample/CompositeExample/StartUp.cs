namespace CompositeExample
{
    using Models;

    public class StartUp
    {
        private static void Main()
        {
            var king = new HeroKing("Sylvanas The Windwalker");

            var grandGeneral = new HeroKing("Illidan The Betrayer");

            var generalProtos = new HeroKing("Thrall");

            var officerTonga = new HeroKing("Muruu");
            officerTonga.Add(new Hero("Azonic"));
            officerTonga.Add(new Hero("Bumble"));
            officerTonga.Add(new Hero("Bhall"));

            var officerHerin = new HeroKing("Kazzak");
            officerHerin.Add(new Hero("Inesta"));
            officerHerin.Add(new Hero("Infeh"));
            officerHerin.Add(new Hero("Sco"));
            officerHerin.Add(new Hero("Ooze"));
            officerHerin.Add(new Hero("Noxe"));

            var officerSalazar = new HeroKing("Sargeras");
            officerSalazar.Add(new Hero("Wazkamuko"));
            officerSalazar.Add(new Hero("Maifax"));
            officerSalazar.Add(new Hero("Shemmari"));
            officerSalazar.Add(new Hero("Pookei"));

            generalProtos.Add(officerHerin);
            generalProtos.Add(officerSalazar);
            generalProtos.Add(officerTonga);

            grandGeneral.Add(generalProtos);

            king.Add(grandGeneral);

            king.Display(1);
        }
    }
}
