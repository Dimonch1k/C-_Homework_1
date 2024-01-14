namespace Task_5_6
{
    internal class Task5_Proxy
    {
        private Task5_PrintList print = new Task5_PrintList();
        public void Check(List<string> words)
        {
            if (EmptyList(words)) return; // If List is empty end
            if (CheckWordsWithIntegers(words)) return; // If there are integers 
            WordsWithoutIntegers(words); // If there aren't integers
        }
        public void WordsWithoutIntegers(List<string> words)
        { // If checking returns true (All words are without integers)
            Console.WriteLine("\nThe List of words is clear and haven't any words with integers.");
            print.Print(words);
        }
        public bool EmptyList(List<string> words)
        {
            if (words == null || words.Count() == 0)
            {
                Console.WriteLine("\nThe list is empty!!!");
                return true;
            }
            return false;
        }
        public bool CheckWordsWithIntegers(List<string> words)
        {
            if (!CheckWords(words)) // If checking return false (Some words have integers)
            {
                if (EmptyList(words)) return true; // If List is empty end

                Console.WriteLine("\nThe words, which have integers were deleted from List.");
                print.Print(words);
                return true;
            }
            return false;
        }

        public bool CheckWords(List<string> words)
        {
            int startCount = words.Count();
            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i] != null)
                {
                    if (ContainInteger(words[i]))
                    {
                        words.Remove(words[i]);
                        i--;
                    }
                    continue;
                }
            }
            if (startCount == words.Count())
            {
                return true;
            }
            return false;
        }
        public bool ContainInteger(string word)
        {
            foreach (char ch in word)
            {
                if (char.IsDigit(ch))
                {
                    return true;
                }
                continue;
            }
            return false;
        }
    }
}
