namespace TextSearch.Lib.Tests;

public class SortedListFinderTests
{
	[Fact]
	public void ExecutionTest()
	{
		// Arrange
		const string phrase = "Now is the winter of our discontent";
		const string pattern = "winter";

		// Act & Assert
		Assert.True(SortedListFinder.Search(phrase, pattern));
	}
}