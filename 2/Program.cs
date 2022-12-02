var input = File.ReadAllLines("input");

var (draw, win, lose) = (3, 6, 0);
var (rock, paper, scissors) = (1, 2, 3);

var solution1 = 0;
// A = rock, B = paper, C = scissors
foreach (string line in input)
{
    solution1 += (line) switch
    {
        ("A X") => draw + rock,
        ("A Y") => win + paper,
        ("A Z") => lose + scissors,
        ("B X") => lose + rock,
        ("B Y") => draw + paper,
        ("B Z") => win + scissors,
        ("C X") => win + rock,
        ("C Y") => lose + paper,
        ("C Z") => draw + scissors,
        _ => throw new ArgumentOutOfRangeException(),
    };
}
Console.WriteLine($"Solution is {solution1}");

var solution2 = 0;
// X = lose, Y = draw, Z = win
foreach (string line in input)
{
    solution2 += (line) switch
    {
        ("A X") => lose + scissors,
        ("A Y") => draw + rock,
        ("A Z") => win + paper,
        ("B X") => lose + rock,
        ("B Y") => draw + paper,
        ("B Z") => win + scissors,
        ("C X") => lose + paper,
        ("C Y") => draw + scissors,
        ("C Z") => win + rock,
        _ => throw new ArgumentOutOfRangeException(),

    };
}
Console.WriteLine($"Solution 2 is {solution2}");
