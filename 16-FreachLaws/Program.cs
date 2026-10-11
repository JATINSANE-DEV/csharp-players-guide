int[] arr = new int[]{4, 51, -7, 13, -99, 15, -8, 45, 90};
int currentSmallest = int.MaxValue;
foreach(int number in arr)
{
    if(number<currentSmallest)
    {
        currentSmallest=number;

    }
}
Console.WriteLine($"The Smallest number is : {currentSmallest}");

int total = 0;
foreach(int number in arr)
{
    total += number;
}
float average = (float)total/arr.Length;
Console.WriteLine($"The Average is : {average}");