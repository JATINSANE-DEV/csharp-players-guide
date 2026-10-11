int[]original = new int[5];

for(int i=0; i<original.Length; i++)
{
    Console.Write($"Enter the {i+1} number : ");
    original[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copy = new int[5];
for(int i=0; i<copy.Length; i++)
{
    copy[i] = original[i];
}
Console.WriteLine();

Console.WriteLine("Original Array contents : ");
for(int i=0; i<original.Length; i++)
{
    Console.WriteLine($"Item {i+1} : {original[i]}");
}
Console.WriteLine("\nReplicated Array contents : ");
for(int i=0; i<copy.Length; i++)
{
    Console.WriteLine($"Item {i+1} : {copy[i]}");
}
