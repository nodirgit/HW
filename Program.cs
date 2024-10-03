
Console.Write("What is radius? ");
double radius = Convert.ToDouble(Console.ReadLine());
double square = Math.Pow(radius, 2) * Math.PI;
double length = Math.PI * radius * 2;
Console.WriteLine($"S: {square} | L: {length}");

Console.Write("The exchange rate is 12,400 sum \n How much do you want to exchange? ");
decimal rate = Convert.ToDecimal(Console.ReadLine());
decimal rated = (decimal)12_400 * rate; 
Console.WriteLine($"{rated} sum");

Console.Write("When were u born? ");
int year = Convert.ToInt32(Console.ReadLine());
int diffrence = (int)2024 - year;
int month = diffrence * 365;
Console.WriteLine($"You are {month} days old.");