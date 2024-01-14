namespace Tasks
{
    internal class Task3
    {
        public void Task_3()
        {
            int tmp, num, reverse = 0;
            Console.Write("Input six-digit number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                tmp = num % 10;
                reverse = (reverse * 10) + tmp;
                num /= 10;
            }
            Console.Write($"Reversed Number: {reverse}\n");
        }
    }
}
