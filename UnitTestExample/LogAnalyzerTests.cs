using Xunit;

namespace UnitTestExample;

public class LogAnalyzerTests
{
    [Theory]
    [InlineData("badextension.bad", false)]
    [InlineData("goodextension.slf", true)]
    [InlineData("goodextension.SLF", true)]
    public void IsValidFileName_BadExtension_ReturnsFalse(string fileName, bool expectedResult)
    {
        LogAnalyzer analyzer = new LogAnalyzer();
        bool result = analyzer.IsValidLogFileName(fileName);
        Assert.Equal(result, expectedResult);
    }

    [Fact]
    public void IsValidFileName_EmptyFileName_ThrowsException()
    {
        LogAnalyzer analyzer = new LogAnalyzer();
        Assert.Throws<ArgumentException>(() => analyzer.IsValidLogFileName(""));
    }

}

