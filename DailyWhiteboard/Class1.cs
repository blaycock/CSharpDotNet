using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("Find the longest string");

        Console.WriteLine("Enter a sentence and i will find the longets word");

        string userSentence = Console.ReadLiine().Trim();

        string[] userWords = userSentence.Split(' ');

        char[] punctuation = new char[] {',','.','!',b};

        string longestWord = "";
        int wordLength = 0;
        foreach (string word in userWords)
        {
            for (int i=0; i< punctuation.Length; i++)
            {
                tempWord = word.Replace(punctuation[i].ToString(), "");
            }

            if (tempWord.Length > longestWord.Length)
            {
                longestWord = tempwoeed;

            }
            wordLength = longestWord.Length;
        }
        Console.WriteLine($"Longest word is '{longestWord}' + '{wordLength'");

    }
}
