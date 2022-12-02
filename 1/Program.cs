List<int> elves = new List<int>();
int current = 0;

foreach (string line in File.ReadAllLines("input.txt"))
{
    try
    {
        current += Int32.Parse(line);
    }
    catch
    {
        elves.Add(current);
        current = 0;
    }
}

Console.WriteLine($"Solution 1 is {elves.Max()}");
Console.WriteLine($"Solution 2 is {elves.OrderByDescending(i => i).Take(3).Sum()}");

