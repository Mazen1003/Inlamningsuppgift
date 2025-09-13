using static Inlämningsuppgift.FootballPlayer;

namespace Inlämningsuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();

            student1.Name = "Mazen";
            student1.age = 25;
            student1.printstudentinfo();



            //skapar en lista av fotbollsspelare
            List<FootballPlayer> team = new List<FootballPlayer>
{
             new Goalkeeper { Name = "Neuer" },
             new Defender { Name = "Ramos" },
             new Forward { Name = "Zlatan" }
};

            foreach (FootballPlayer player in team)
            {
                player.Play();
                // Samma metod (Play) anropas
                // men olika versioner körs beroende på spelartyp
            }
            Animal dog = new Animal();

            // Sätter värden via properties (inte direkt till fälten)
            dog.Name = "Häst";
            dog.Age = 10;

            dog.PrintInfo(); // Skriver ut: "Djur: Häst, Ålder: 10"

            // Testar ogiltiga värden
            dog.Name = "";   // Namnet kan inte vara tomt!
            dog.Age = -3;    // Ogiltig ålder!

            //jag vill skapa objekt av mina bilar
            Cars myVolvo = new Volvo();
            Cars myTesla = new Tesla();
            //anropar metoden drive på varje bil
            myVolvo.drive();
            myTesla.drive();
        }

    }
}
