namespace Inlämningsuppgift
{
    // Basklass 
    public class Arv
    {
        public string Name;
        public int age;
    }
    // Subklass
    class student : Arv
    {
        public string studentinfo;
        public void printstudentinfo()
        {
            Console.WriteLine($"Hej, jag heter {Name} och jag är {age} år gammal.");
        }
    }
}
