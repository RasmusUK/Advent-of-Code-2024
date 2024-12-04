namespace AdventOfCode2024;

public class Reader
{
    private readonly string pathRootFolder = Path.Combine(AppContext.BaseDirectory, @"..\..\..");
    public List<string> ReadLines(int day, string fileName)
    {
        var directory = @$"Days\Day{day}";
        var filePath = Path.Combine(pathRootFolder, directory, fileName);
        return File.ReadAllLines(filePath).ToList();
    }
}