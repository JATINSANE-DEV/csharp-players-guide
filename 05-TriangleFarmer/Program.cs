Console.WriteLine("What is the base of the Triangle?");
double baseValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The base of the triangle is : " + baseValue +"cm");

Console.WriteLine("What is the height of the Triangle?");
double heightValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The height of the Triangle is : " + heightValue +"cm");

double area = (baseValue*heightValue)/2.0;
Console.WriteLine("The area of this Triangle is : " + area + "square cm");