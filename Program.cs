using System;
class Lab3
{
    static void Main()
    {
        string sentence1 = "Я учусь в рмт!";
        string sentence2 = "Я учусь не в рмт!";

        string[] words1 = sentence1.Split(' ');
        string[] words2 = sentence2.Split(' ');
        foreach (string word1 in words1)
        {
            int count = 0;
            foreach (string word2 in words2)
            {
                if (word1 == word2)
                {
                    count++;
                }
            }
            Console.WriteLine($"Слово '{word1}' встречается {count} раза во втором предложении 2");
        }
    }
}
