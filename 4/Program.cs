var input = File.ReadAllLines("input");
int Solution1 = 0, Solution2 = 0;
foreach (string line in input)
{
    var found = false;
    var pairs = line.Split(",");
    var rangeA = pairs[0].Split("-");
    var rangeB = pairs[1].Split("-");

    int A1 = Int32.Parse(rangeA[0]),
        A2 = Int32.Parse(rangeA[1]),
        B1 = Int32.Parse(rangeB[0]),
        B2 = Int32.Parse(rangeB[1]);

    // Solution 1
    if (A1 <= B1 && A2 >= B2)
    {
        Solution1++;
        found = true;
    }
    if ((B1 <= A1 && B2 >= A2) && (!found)) Solution1++; // Do not repeat if already found

    // Solution 2
    if ((B2 >= A1 && A2 >= B1) || (A2 >= B1 && A1 <= B2)) Solution2++;
}
Console.WriteLine($"Solution1 is: {Solution1}");
Console.WriteLine($"Solution2 is: {Solution2}");

