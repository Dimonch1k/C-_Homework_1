namespace Task_7_8
{
    internal interface Task8_Order
    {
        int Id { get; set; }
        double Price { get; set; }

        void makeOrder();
    }
}
