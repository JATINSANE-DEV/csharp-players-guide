// All the 14 types of primitive types:-

// 1. Integer type(there are 8):-
byte health = 150;
Console.WriteLine("Health is : " + health);
sbyte damage = -100;
Console.WriteLine("Damage taken : "+ damage);
ushort highestRank = 20;
Console.WriteLine("The Player's highest rank reached was : " + highestRank);
short highestDeductedRank = -80;
Console.WriteLine("The Players Highest rank deducted was : " + highestDeductedRank);
long totalDamageTaken = -100000L;
Console.WriteLine("The Player's total taken damage is : " + totalDamageTaken);
ulong totalDamageGiven = 2000000UL;
Console.WriteLine("The Player's total given damage is : " + totalDamageGiven);
uint totalNadeDamageGiven = 20000U;
Console.WriteLine("Players total damage given by nade : " + totalNadeDamageGiven);
int totalNadeDamageTaken = 10000;
Console.WriteLine("The Players's has taken total nade damage by nade is : " + totalNadeDamageTaken);

// 2. Floating-Point Types
float killsPerDeath = 3.6f;
Console.WriteLine("The Player's K/D is : " + killsPerDeath);
decimal killsPerMinute = 1.94m;
Console.WriteLine("The Player's kills per minute is : " + killsPerMinute);
double lastMatchKd = 2.4;
Console.WriteLine("The Players last match's K/D was : " + lastMatchKd);

// 3. Text & Character Types
char playerDogtag = 'J';
Console.WriteLine("The Player's dogtag is : " + playerDogtag);
string playerName = "Jatin Popa";
Console.WriteLine("The Player's name is : " + playerName);

// 4. Boolean & Logic Type
bool isAlive = true;
Console.WriteLine("Is the Player Alive? : " + isAlive);