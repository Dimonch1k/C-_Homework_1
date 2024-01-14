namespace Task_7_8
{
    internal class Task8_Program
    {
        public void Task_8()
        {
            Task8_Order onlineOrder = new Task8_OnlineOrder();
            Task8_Order inStoreOrder = new Task8_InStoreOrder();

            onlineOrder.Price = 60;
            onlineOrder.Id = 93624521;

            inStoreOrder.Price = 40;
            inStoreOrder.Id = 59245693;

            onlineOrder.makeOrder();
            inStoreOrder.makeOrder();
        }
    }
}
