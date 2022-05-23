int yesCount = 2;
int noCount = 3;
int maybeCount = 4;

int total = yesCount + noCount + maybeCount;

var yesPercent = Math.Round(yesCount * 100.0 / total, 2);
var noPercent = Math.Round(noCount * 100.0 / total, 2);
var maybePercent = Math.Round(maybeCount * 100.0 / total, 2);

var excess = Math.Round(100 - yesPercent - noPercent - maybePercent, 2);

Console.WriteLine(excess);

if(yesCount > noCount)
{
    if(maybeCount > yesCount)
    {
        Console.WriteLine("Maybe won");
        maybePercent += excess;
    }
    else if (yesCount > maybeCount)
    {
        Console.WriteLine("Yes won");
        yesPercent += excess;
    }
    else
    {
        Console.WriteLine("Draw");
    }
}
else if(noCount > yesCount)
{
    if (maybeCount > noCount)
    {
        Console.WriteLine("Maybe won");
        maybePercent += excess;
    }
    else if (noCount > maybeCount)
    {
        Console.WriteLine("No won");
        noPercent += excess;
    }
    else
    {
        Console.WriteLine("Draw");
    }
}
else
{
    if (yesCount < maybeCount)
    {
        Console.WriteLine("Maybe won");
        maybePercent += excess;
    }
    else
    {
        Console.WriteLine("Draw");
    }
}

Console.WriteLine($"Yes count: {yesCount}, Yes Percentage {Math.Round(yesPercent, 2)}");
Console.WriteLine($"No count: {noCount}, No Percentage {Math.Round(noPercent, 2)}");
Console.WriteLine($"Yes count: {maybeCount}, Yes Percentage {Math.Round(maybePercent, 2)}");