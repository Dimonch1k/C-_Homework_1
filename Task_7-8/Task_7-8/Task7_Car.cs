namespace Tasks
{
    internal class Task7_Car : Task7_Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public void Run()
        {
            Console.WriteLine("Car:");
            Console.WriteLine($"  Brand: {Brand}");
            Console.WriteLine($"  Year: {Year}");
            Console.WriteLine("  I travel on four-wheels\n");
        }
    }
}
