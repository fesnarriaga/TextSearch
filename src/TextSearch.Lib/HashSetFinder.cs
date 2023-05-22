namespace TextSearch.Lib;

public class HashSetFinder
{
	public static bool Search(string text, string pattern)
	{
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
			return false;

		var hashSet = new HashSet<string> { pattern };

		var patternLength = pattern.Length;
		var textLength = text.Length;

		for (var i = 0; i <= textLength - patternLength; i++)
		{
			var subString = text.Substring(i, patternLength);

			if (hashSet.Contains(subString))
				return true;
		}

		return false;
	}
}