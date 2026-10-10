int targetNumber;
while(true)
{
    Console.Write("User 1, enter a number between 0 and 100 : ");
    targetNumber = Convert.ToInt32(Console.ReadLine());
    if(targetNumber>=0 && targetNumber<=100)
    {
        break;
    }
}
Console.Clear();
Console.WriteLine("User 2, guess the number.");
while(true)
{
    Console.Write("User 2, What is your next guess? : ");
    int guessNumber = Convert.ToInt32(Console.ReadLine());
    if(guessNumber>targetNumber)
    {
        Console.WriteLine($"{guessNumber} is too high.");
    }
    else if(guessNumber<targetNumber)
    {
        Console.WriteLine($"{guessNumber} is too low.");
    }
    else if(guessNumber==targetNumber)
    {
        Console.WriteLine("You guessed the number!");
        break;
    }
}