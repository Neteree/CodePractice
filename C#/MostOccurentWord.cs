using System;
using System.Collections.Generic;

class Program
{
	private static Dictionary<string, int> GetWordOccurrences(string[] words)
	{
		Dictionary<string, int> wordOccurrences = new();
		
		foreach(string word in words)
		{
			if(!wordOccurrences.ContainsKey(word))
			{
				wordOccurrences[word] = 1;
			}
			else
			{
				wordOccurrences[word]++;
			}
		}
		
		return wordOccurrences;
	}
	
	private static string GetMostOccurrentWord(Dictionary<string, int> wordOccurrences)
	{
		string mostOccurrentWord = "";
		
		foreach(var word in wordOccurrences.Keys)
		{
			if (mostOccurrentWord == "")
			{
				mostOccurrentWord = word;
			}
			
			if(wordOccurrences[word] > wordOccurrences[mostOccurrentWord])
			{
				mostOccurrentWord = word;
			}
		}
		
		return mostOccurrentWord;
	}
	
    static void Main()
    {
		string[] words = {
			"apple",
			"apple",
			"orrange",
			"banana",
			"apple",
			"orrange",
			"orrange",
			"banana",
			"orrange"
		};
		
		Dictionary<string, int> wordOccurrences = GetWordOccurrences(words);
		string mostOccurrentWord = GetMostOccurrentWord(wordOccurrences);
		
		Console.WriteLine(mostOccurrentWord);
    }
}
