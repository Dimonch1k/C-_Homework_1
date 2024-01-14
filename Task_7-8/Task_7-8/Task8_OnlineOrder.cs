namespace Task_7_8
{
    internal class Task8_OnlineOrder : Task8_Order
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public void makeOrder()
        {
            Console.WriteLine("Online order:");
            Console.WriteLine("  The order will arrive to you in 20 minutes.");
            Console.WriteLine($"  Order id: {Id}");
            Console.WriteLine($"  Order price: {Price}\n");
        }
    }
}
