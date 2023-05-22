using BenchmarkDotNet.Attributes;

namespace TextSearch.Lib.Benchmark;

public class SearchBenchmark
{
	private const string Text = "abcdefghijklmnopqrstuvwxyz";
	private const string Pattern = "cd";
	private const int Iterations = 1000000;

	private readonly Trie _trie;

	public SearchBenchmark()
	{
		_trie = new Trie();
		_trie.Add(Pattern);
	}

	[Benchmark]
	public void TrieSearch()
	{
		for (var i = 0; i < Iterations; i++)
			_trie.Search(Text);
	}

	[Benchmark]
	public void HashSetSearch()
	{
		for (var i = 0; i < Iterations; i++)
			HashSetFinder.Search(Text, Pattern);
	}

	[Benchmark]
	public void ListSearch()
	{
		for (var i = 0; i < Iterations; i++)
			ListFinder.Search(Text, Pattern);
	}

	[Benchmark]
	public void SortedListSearch()
	{
		for (var i = 0; i < Iterations; i++)
			SortedListFinder.Search(Text, Pattern);
	}
}