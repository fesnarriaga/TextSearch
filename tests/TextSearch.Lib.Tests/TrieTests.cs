namespace TextSearch.Lib.Tests;

public class TrieTests
{
	[Fact]
	public void ExecutionTest()
	{
		// Arrange
		var sut = new Trie();
		const string phrase = "Now is the winter of our discontent";

		// Act
		foreach (var word in phrase.Split(' '))
			sut.Add(word);

		// Assert
		Assert.True(sut.Search("winter"));
	}
}