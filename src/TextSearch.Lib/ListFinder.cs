namespace TextSearch.Lib;

public class ListFinder
{
	public static bool Search(string text, string pattern)
	{
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern) || text.Length < pattern.Length)
			return false;

		var substrings = new List<string>();
		var patternLength = pattern.Length;
		var textLength = text.Length;

		for (var i = 0; i <= textLength - patternLength; i++)
		{
			substrings.Add(text.Substring(i, patternLength));
		}

		return substrings.Contains(pattern);
	}
}