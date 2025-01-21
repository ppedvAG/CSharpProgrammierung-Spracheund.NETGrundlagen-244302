Console.Write("Meter: ");
string meter = Console.ReadLine();
int m = int.Parse(meter);

Console.Write("Stunden: ");
string stunden = Console.ReadLine();
int std = int.Parse(stunden);

Console.Write("Minuten: ");
string minuten = Console.ReadLine();
int min = int.Parse(minuten);

Console.Write("Sekunden: ");
string sekunden = Console.ReadLine();
int sek = int.Parse(sekunden);

double gesamt = std * 3600 + min * 60 + sek;

Console.WriteLine($"Meter/Sekunde: {Math.Round(m / gesamt, 2)}");
double kilometer = m / 1000.0;
double stunde = gesamt / 3600;
Console.WriteLine($"Kilometer/Stunde: {Math.Round(kilometer / stunde, 2)}");
Console.WriteLine($"Meilen/Stunde: {Math.Round(kilometer / stunde * 0.62137119, 2)}");