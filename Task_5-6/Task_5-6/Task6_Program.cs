namespace Task_5_6
{
    internal class Task6_Program
    {
        public void Task_6()
        {
            Task6_Fibonacci fibonacci = new Task6_Fibonacci();
            Task6_Functions functions = new Task6_Functions();

            int range = functions.Range();
            fibonacci.FibonacciNumbers(range);
        }
    }
}
