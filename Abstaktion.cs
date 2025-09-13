namespace Inlämningsuppgift
{
    // Abstrakt klass för bilar
    abstract class Cars
    {
        // Abstrakt metod som måste implementeras i subklasser
        public abstract void drive();
    }
    // Subklass Volvo
    class Volvo : Cars
        {
        public override void drive()
        {
            Console.WriteLine("Volvo är den säkraste bilen.");
        }
    }
    // Subklass Tesla
        class Tesla : Cars
    {   public override void drive()
        {
            Console.WriteLine("Tesla är en elbil.");
        }
    }

}
