using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 1:");
        string NewString = "gjtry4kdlfld6kliok45";
        Console.WriteLine(NewString);
        char ChoosenLetter = 'k';

        int count = 0;
        for (int i = 0; i < NewString.Length; i++)
        {
            if (NewString[i] == ChoosenLetter)
            {
                count++;
            }
        }

        Console.WriteLine($"Letter '{ChoosenLetter}' appears {count} times in the string");

        Console.WriteLine("Task 2:");

        string CorrectString = "IPZ23theBEST";
        char Symbol = '-';
        string ChangedString = "";
        Console.WriteLine($"String without changes: {CorrectString}");

        for (int i = 0; i < CorrectString.Length; i++)
        {
            ChangedString += Symbol + CorrectString[i].ToString();
        }
        Console.WriteLine($"String separated by '-': {ChangedString}");

        Console.WriteLine("Task 3:");

        string Start = "Арка Алка тата Анна";
        string[] words = Start.Split(' ');

        Console.WriteLine("Words that start and end with the same letter:");
        foreach (string word in words)
        {
            string lowerWord = word.ToLower();
            if (lowerWord[0] == lowerWord[lowerWord.Length - 1])
            {
                Console.WriteLine(word);
            }
        }

        Console.WriteLine("Task 4:");
        Console.WriteLine("Enter the sentense:");
        string NewSentence = Console.ReadLine();
        string[] wordss = NewSentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string oddWords = "";
        string evenWords = "";
        for (int i = 0; i < wordss.Length; i++)
        {
            if ((i + 1) % 2 != 0)
            {
                oddWords += wordss[i] + " ";
            }
            else
            {
                evenWords += wordss[i] + " ";
            }
        }
        Console.WriteLine("Words with nonpaired numbers:");
        Console.WriteLine(oddWords.Trim());

        Console.WriteLine("Words with paired numbers:");
        Console.WriteLine(evenWords.Trim());

    }
}