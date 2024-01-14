using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_6
{
    internal class Task5_Program
    {
        public void Task_5()
        {
            List<string> words = new List<string>();
            Task5_Proxy proxy = new Task5_Proxy();
            Task5_PrintList print = new Task5_PrintList();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Input {i + 1} word: ");
                words.Add(Console.ReadLine());
            }
            proxy.Check(words);
        }
    }
}
