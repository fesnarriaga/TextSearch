namespace TextSearch.Lib;

public class SortedListFinder
{
	public static bool Search(string text, string pattern)
	{
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern) || text.Length < pattern.Length)
			return false;

		var substrings = new SortedList<string, bool>();
		var patternLength = pattern.Length;
		var textLength = text.Length;

		for (var i = 0; i <= textLength - pattern.Length; i++)
		{
			substrings[text.Substring(i, patternLength)] = true;
		}

		return substrings.ContainsKey(pattern);
	}
}