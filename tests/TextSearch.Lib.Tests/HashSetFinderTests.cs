namespace TextSearch.Lib.Tests;

public class HashSetFinderTests
{
	[Fact]
	public void ExecutionTest()
	{
		// Arrange
		const string phrase = "Now is the winter of our discontent";
		const string pattern = "winter";

		// Act & Assert
		Assert.True(HashSetFinder.Search(phrase, pattern));
	}
}