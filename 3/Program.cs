var input = File.ReadAllLines("input");

// a = 1, z = 26, A = 27, Z = 52
var scores = new Dictionary<string, int>();
char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
var i = 1;
foreach (char c in chars)
{
    scores.Add(c.ToString(), i);
    i++;
}

var solution1 = 0;
foreach (string line in input)
{
    var compartmentA = (line.Substring(0, line.Length / 2));
    var compartmentB = (line.Substring(line.Length - line.Length / 2, line.Length / 2));
    foreach (char c in compartmentA)
    {
        if (compartmentB.Contains(c))
        {
            solution1 += scores[c.ToString()];
            break;
        }
    }
}
Console.WriteLine($"Solution 1: {solution1}");

// Badges
var solution2 = 0;
for (int n = 0; n < input.Length;)
{
    var r = input[n].ToCharArray()
      .Intersect(input[n + 1].ToCharArray()
      .Intersect(input[n + 2].ToCharArray()));

    foreach (char l in r)
    {
        solution2 += scores[l.ToString()];
    }
    n = n + 3;
}
Console.WriteLine($"Solution 2: {solution2}");

