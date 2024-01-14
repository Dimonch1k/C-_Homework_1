namespace Task_5_6
{
    internal class Task5_PrintList
    {
        public void Print(List<string> words)
        {
            Console.Write("Words: ");
            words.ForEach(w => { Console.Write($"[ {w} ] "); });
            Console.WriteLine();
        }
    }
}
