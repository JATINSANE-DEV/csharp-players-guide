Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int tRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int tColumn = Convert.ToInt32(Console.ReadLine());

int leftRow = tRow, leftColumn = tColumn - 1;
int downRow = tRow - 1, downColumn = tColumn;
int rightRow = tRow, rightColumn = tColumn + 1;
int upRow = tRow + 1, upColumn = tColumn;

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine("Deploy to : ");
Console.WriteLine($"({leftRow}, {leftColumn})");
Console.WriteLine($"({downRow}, {downColumn})");
Console.WriteLine($"({rightRow}, {rightColumn})");
Console.WriteLine($"({upRow}, {upColumn})");

Console.ResetColor();
Console.Beep();