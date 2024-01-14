namespace Task_7_8
{
    internal class Task8_InStoreOrder : Task8_Order
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public void makeOrder()
        {
            Console.WriteLine("In store order: ");
            Console.WriteLine("  Your order will be delivered now.");
            Console.WriteLine($"  Order id: {Id}");
            Console.WriteLine($"  Order price: {Price}\n");
        }
    }
}
