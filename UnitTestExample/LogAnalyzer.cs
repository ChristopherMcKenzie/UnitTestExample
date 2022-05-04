namespace UnitTestExample;

public class LogAnalyzer
{
    public bool IsValidLogFileName(string filename)
    {
        
        if (String.IsNullOrEmpty(filename) || String.IsNullOrWhiteSpace(filename))
        {
            throw new ArgumentException("Filename has not been provided");
        }
        
        if (!filename.EndsWith(".SLF", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }
        
        return true;
    }
}