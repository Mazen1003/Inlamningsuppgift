namespace Inlämningsuppgift
{
    public class FootballPlayer
    {
        //basklass för fotbollsspelare
        public string Name;
        public virtual void Play()
        {
            Console.WriteLine($"{Name} spelar fotboll.");
        }
        //Anfallare
        public class Forward : FootballPlayer
        {
            public override void Play()
            {
                Console.WriteLine($"{Name} spelar som anfallare och gör mål.");
            }
        }
    } //Försvare
    public class Defender : FootballPlayer
    {
        public override void Play()
        {
            Console.WriteLine($"{Name} spelar som försvarare och stoppar motståndarna.");
        }
    } //Målvakt
    public class Goalkeeper : FootballPlayer
    {
        public override void Play()
        {
            Console.WriteLine($"{Name} spelar som målvakt och räddar skott.");
        }
    }

}
