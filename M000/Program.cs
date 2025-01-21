bool schaltjahr = false;
int jahr = 2020;
if (jahr % 4 == 0)
	schaltjahr = true;
if (jahr % 100 == 0)
	schaltjahr = false;
if (jahr % 400 == 0)
	schaltjahr = true;

if (schaltjahr)
	Console.WriteLine($"{jahr} ist ein Schaltjahr");
else
	Console.WriteLine($"{jahr} ist kein Schaltjahr");


int[] zahlen = [14, 73, 28, 77, 4];
int zahl = 33;
if (zahl >= 0 && zahl <= 100)
{
	if (zahlen.Contains(zahl))
	{
		Console.WriteLine("Glückwunsch");
	}
	else
	{
		Console.WriteLine("Keine Zahl getroffen");
	}
}
else
{
	Console.WriteLine("Zahl ist nicht im Bereich (0-100)");
}