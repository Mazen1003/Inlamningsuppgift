namespace Inlämningsuppgift
{
    internal class Arv
    {
        public string Name;
        public int age;
    }
    class student : Arv
    {
        public string studentinfo;
        public void printstudentinfo()
        {
            Console.WriteLine($"Hej, jag heter {Name} och jag är {age} år gammal.");
        }
    }
}
