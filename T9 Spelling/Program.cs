using System;
using System.Collections.Generic;

namespace T9_Spelling
{
    internal class Program
    {
        private static void Main()
        {
            Dictionary<string, int> translation = new Dictionary<string, int>();

            translation.Add("a", 2);
            translation.Add("b", 22);
            translation.Add("c", 222);
            translation.Add("d", 3);
            translation.Add("e", 33);
            translation.Add("f", 333);
            translation.Add("g", 4);
            translation.Add("h", 44);
            translation.Add("i", 444);
            translation.Add("j", 5);
            translation.Add("k", 55);
            translation.Add("l", 555);
            translation.Add("m", 6);
            translation.Add("n", 66);
            translation.Add("o", 666);
            translation.Add("p", 7);
            translation.Add("q", 77);
            translation.Add("r", 777);
            translation.Add("s", 7777);
            translation.Add("t", 8);
            translation.Add("u", 88);
            translation.Add("v", 888);
            translation.Add("w", 9);
            translation.Add("x", 99);
            translation.Add("y", 999);
            translation.Add("z", 9999);

            int n = Int32.Parse(Console.ReadLine());
            List<string> inputs = new List<string>();

            for (int i = 0; i < n; i++)
            {
                inputs.Add(Console.ReadLine());
            }
            n = 0;
            foreach (string item in inputs)
            {
                n++;
                int tempInt;
                int oldTemp = 0;
                string temp = String.Empty;

                foreach (var character in item)
                {
                    translation.TryGetValue(character.ToString(), out tempInt);
                    if (oldTemp.ToString()[0] == tempInt.ToString()[0])
                    {
                        temp += " ";
                    }

                    temp += tempInt.ToString();
                    oldTemp = tempInt;
                }
                Console.WriteLine("Case #" + n + ": " + temp);
            }
        }
    }
}