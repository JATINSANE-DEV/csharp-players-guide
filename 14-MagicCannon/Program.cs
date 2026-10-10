for(int turn=1; turn<=100; turn++)
{
    if(turn%3==0 && turn%5==0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{turn}: Combined Blast");
    }
    else if(turn%3==0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{turn}: Fire");
        
    }
    else if(turn%5==0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{turn}: Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{turn}: Normal");
    }
}
Console.ResetColor();
Console.WriteLine();