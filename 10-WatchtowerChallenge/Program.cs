Console.Write("Enter the value of x : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of y : ");
int y = Convert.ToInt32(Console.ReadLine());
if(x<0 && y>0)
{
    Console.WriteLine("The enemy is to the NorthWest!");
}
else if(x==0 && y>0)
{
    Console.WriteLine("The enemy is to the North!");
}
else if(x>0 && y>0)
{
    Console.WriteLine("The enemy is to the NorthEast!");
}
else if(x<0 && y==0)
{
    Console.WriteLine("The enemy is to the West!");
}
else if(x==0 && y==0)
{
    Console.WriteLine("The enemy is here");
}
else if(x>0 && y==0)
{
    Console.WriteLine("The enemy is to the East");
}
else if(x<0 && y<0)
{
    Console.WriteLine("The enemy is to the SouthWest");
}
else if(x==0 && y<0)
{
    Console.WriteLine("The enemy is to the South");
}
else if(x>0 && y<0)
{
    Console.WriteLine("The enemy is to the SouthEast");
}