using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "abc";
        string startMarker = "a";
        string endMarker = "c";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("b"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "abc";
        string startMarker = "e";
        string endMarker = "c";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "abc";
        string startMarker = "a";
        string endMarker = "e";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "abc";
        string startMarker = "e";
        string endMarker = "f";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string startMarker = "e";
        string endMarker = "c";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "eded";
        string startMarker = "ed";
        string endMarker = "de";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }
}
