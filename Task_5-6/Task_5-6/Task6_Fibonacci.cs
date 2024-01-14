namespace Task_5_6
{
    internal class Task6_Fibonacci
    {
        public void FibonacciNumbers(int range)
        {
            int first = 0, next = 1, sum = first + next;

            Console.Write("Fibonacci numbers: ");
            Console.Write($"{first} {next}");
            while (sum < range)
            {
                Console.Write($" {sum}");
                first = next;
                next = sum;
                sum = first + next;
            }
            Console.WriteLine();
        }
    }
}
