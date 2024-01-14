namespace Tasks
{
    internal class Task2
    {
        public void Task_2()
        {
            List<int> ints = new List<int>(); // Create List
            double sum = 0;                   // Create variable for counting sum
            double multi = 1;                 // Create variable for counting the multiplication

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Input {i + 1} number: ");
                int num = Convert.ToInt32(Console.ReadLine()); // Convert (string -> int)
                ints.Add(num); // Add number to array
                sum += num;
                multi *= num;
            }
            Console.Write("\nNumbers in array: ");
            ints.ForEach(x => Console.Write(x + " ")); // Print all numbers on the screen

            int max = ints.Max(); // Find Max element in List
            int min = ints.Min(); // Find Min element in List

            Console.WriteLine($"\nMax: {max} \nMin: {min} \nSum: {sum} \nMultiplication: {multi}\n");
        }
    }
}
