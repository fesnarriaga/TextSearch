namespace TextSearch.Lib;

public class Trie
{
	private readonly TrieNode _rootNode = new();

	public void Add(string word)
	{
		var node = _rootNode;

		foreach (var character in word.Where(character => !node.Children.ContainsKey(character)))
		{
			node.Children[character] = new TrieNode();

			node = node.Children[character];
		}

		node.IsWord = true;
	}

	public bool Search(string word)
	{
		var node = _rootNode;

		foreach (var character in word)
		{
			if (!node.Children.ContainsKey(character))
				return false;

			node = node.Children[character];
		}

		return node.IsWord;
	}
}