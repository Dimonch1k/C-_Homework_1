namespace Task_5_6
{
    internal class Task6_Functions
    {
        public int Range() // User input range for Fibonacci numbers 
        {
            while (true)
            {
                Console.Write("Input range for Fibonacci numbers: ");
                int range = Convert.ToInt32(Console.ReadLine());
                if (LessLargeEquals(range)) continue;
                return range;
            }
        }
        public bool LessLargeEquals(int range)
        {
            if (range < 0) // If range less than 0
            {
                Console.WriteLine("The range is UNACCEPTABLE!!!");
                Console.WriteLine("PLEASE input another range MORE than 0!!!");
                TimeDelay();
                ClearConsole();
                return true;
            }
            if (range.Equals(0))
            {
                Console.WriteLine("Fibonacci numbers: 0");
                Environment.Exit(0);
            }
            return false;
        }
        public void ClearConsole() // Clear Console 
        {
            Console.Clear();
        }
        public void TimeDelay() // Time Delay for 2 sec 
        {
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
        }
    }
}
