namespace Tasks
{
    internal class Task7_Motorcycle : Task7_Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public void Run()
        {
            Console.WriteLine("Motorcycle:");
            Console.WriteLine($"  Brand: {Brand}");
            Console.WriteLine($"  Year: {Year}");
            Console.WriteLine("  I travel on two-wheels");
        }
    }
}
