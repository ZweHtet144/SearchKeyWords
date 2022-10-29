# SearchKeyWords
# Reference Source Link
1-https://ideone.com/kEDoXA
2-https://www.cambiaresearch.com/articles/6/extract-keywords-from-a-search-string-in-csharp


#Link-1 Code


using System;
using System.Text.RegularExpressions;
using System.IO;
public class Test
{
	public static void Main()
	{
		var searchString = "to find";
		var pattern = @"\b" + searchString + @"\b";    //searchString is passed in.
		Regex rgx = new Regex(pattern);
		var sentence = "I need to find a string in this sentence!";
		Match match = rgx.Match(sentence);
		if (match.Success)
		{
    		Console.WriteLine(match.Value);
		}
	}
}

#Link-2 Code

public static string[] GetSearchWords(string text)
{
	string pattern = @"\S+";
	Regex re = new Regex(pattern);

	MatchCollection matches = re.Matches(text);
	string[] words = new string[matches.Count];
	for (int i=0; i<matches.Count; i++)
	{
		words[i] = matches[i].Value;
	}
	return words;
}

