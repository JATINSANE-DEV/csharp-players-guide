Console.Write("Enter the number of Estates : ");
int estates = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of Duchy : ");
int duchy = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of Province : ");
int province = Convert.ToInt32(Console.ReadLine());

int estatePoints = 1;
int duchyPoints = 3;
int provincePoints = 6;

int totalPointEstates = estates*estatePoints;
int totalPointDuchy = duchy*duchyPoints;
int totalPointProvince = province*provincePoints;

int totalPoints = totalPointEstates+totalPointDuchy+totalPointProvince;
Console.WriteLine("The total Number of points are : " + totalPoints + " pts");
