namespace AdventOfCode2024.Days;

public abstract class Day
{
    private readonly List<string> example1;
    private readonly List<string> example2;
    private readonly List<string> input;
    
    protected Day(int day)
    {
        var reader = new Reader();
        example1 = reader.ReadLines(day, "Example1.txt");
        example2 = reader.ReadLines(day, "Example2.txt");
        input = reader.ReadLines(day, "Input.txt");
    }

    public void Run()
    {
        Console.WriteLine($"Part1 (example / input): ({Part1(example1)} / {Part1(input)})\n" +
                          $"Part2 (example / input): ({Part2(example2)} / {Part2(input)})");
    }

    protected abstract object Part1(List<string> input);

    protected abstract object Part2(List<string> input);

    protected void PrintDebug(List<string> list)
    {
        foreach (var line in list)
        {
            Console.WriteLine(line);
        }
    }
}