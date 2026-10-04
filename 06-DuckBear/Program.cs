Console.WriteLine("Total number of Eggs are : ");
int eggs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("There are 4 Sisters");
int each = eggs / 4;
Console.WriteLine("Each Sister will get : " + each + " eggs");
int eggsForDuckBear = eggs%4;
Console.WriteLine("The DuckBear will eat : " + eggsForDuckBear + " egg(s)");

// The tree total egg counts where the duckbear gets more than each sister does are = 6,7 and 11,etc