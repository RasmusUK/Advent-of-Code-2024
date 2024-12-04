Console.WriteLine("Welcome to code of advent");

var day = 0;
var parseSuccess = false;

while (!parseSuccess)
{
    Console.WriteLine("Please enter day:");
    parseSuccess = int.TryParse(Console.ReadLine(), out day);
}

var className = $"AdventOfCode.Days.Day{day}.Day{day}";
var type = Type.GetType(className);

if (type is null)
{
    Console.WriteLine($"Class {className} not found");
    return; 
}

var parameters = new object[]{ day };
var instance = Activator.CreateInstance(type, parameters);
var method = type.GetMethod("Run");

if (method is null)
{
    Console.WriteLine($"Method 'Run' not found in {className}");
    return;
}
    
method.Invoke(instance, null);