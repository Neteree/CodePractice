using System;

class Program
{
	private static string GetReversedWordsString(string wordsString)
    {
        string[] words = wordsString.Split(" ");
        string reversedWordsString = "";
        
        foreach(string word in words)
        {
        	for(int i = word.Length - 1; i >= 0; i--)
            {
            	reversedWordsString += word[i];
            }
        } 
        
        return reversedWordsString;
    }

    static void Main()
    {
    	string wordString = "Pineapple is so good on pizza";
    	string reversedWordsString = GetReversedWordsString(wordString);
        
        Console.WriteLine(reversedWordsString);
    }
}
