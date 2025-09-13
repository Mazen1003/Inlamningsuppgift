namespace Inlämningsuppgift
{
    public class Animal
    {
        // Privat fält (går inte att komma åt direkt utifrån)
        private string name;

        // Egenskap (property) som ger kontrollerad åtkomst
        public string Name
        {
            get { return name; }
            set
            {
                // Enkel kontroll: namnet får inte vara tomt
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Namnet kan inte vara tomt!");
            }
        }

        // Privat fält för ålder
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                // Ålder måste vara positiv
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Ogiltig ålder!");
            }
        }

        // Metod för att visa information
        public void PrintInfo()
        {
            Console.WriteLine($"Djur: {Name}, Ålder: {Age}");
        }
    }
}
