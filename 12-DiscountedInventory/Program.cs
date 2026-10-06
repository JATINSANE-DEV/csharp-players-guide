Console.WriteLine("The following items are available : ");
Console.WriteLine(@"1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies");

Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
Console.WriteLine("What number do you want to see the price of? ");
int choice = Convert.ToInt32(Console.ReadLine());

string? item = "";
double price = 0;
switch(choice)
{
    case 1:
    item = "Rope";
    price = 10;
    break;

    case 2:
    item = "Torches";
    price = 15;
    break;

    case 3:
    item = "Climbing Equipment";
    price = 25;
    break;

    case 4:
    item = "Clean Water";
    price = 1;
    break;

    case 5:
    item = "Machete";
    price = 20;
    break;

    case 6:
    item = "Canoe";
    price = 200;
    break;

    case 7:
    item = "Food Supplies";
    price = 1;
    break;

    default:
    Console.WriteLine("\"Please enter a number from the menu only\" ");
    return;
}
if(name == "Jatin")
{
    price/=2;
}
Console.WriteLine($"{item} costs {price} gold");