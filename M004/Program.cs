#region Schleifen
//Schleifen
//Bestimmten Code mehrmals ausführen

//while
//Enthält eine Bedingung
//Am Ende der Schleife wird die Bedingung geprüft, und die Schleife wiederholt, wenn die Bedingung wahr ist
using System.Net;

int a = 0;
int b = 10;
while (a < b)
{
    Console.WriteLine($"while: {a}");
	a++;
}

//do-while
//Enthält eine Bedingung
//Selbiges wie while, ABER diese Schleife wird immer einmal ausgeführt, auch wenn die Bedingung von Anfang an falsch ist
a = 0;

do
{
	Console.WriteLine($"do-while: {a}");
	a++;
}
while (a < b);

//Endlosschleife
//Läuft für immer/bis sie beendet wird
a = 0;

while (true)
{
    Console.WriteLine($"while-true: {a}");
	a++;

	if (a >= b)
		break;
}

//break und continue

//break: Beendet die Schleife
//break wird generell mit einer If-Bedingung kombiniert

//continue: Überspringt den Code danach, und geht zum Schleifenkopf zurück
//continue wird generell mit einer If-Bedingung kombiniert
a = 0;

while (a < b)
{
	a++;
	if (a % 2 == 0)
		continue;
    Console.WriteLine($"{a}");
}

//for-Schleife
//Schleife, welche einen Zähler eingebaut hat
for (int i = 0; i < 10; i++) //for + Tab
{
    Console.WriteLine($"for: {i}");
}

//Iterieren eines Arrays
int[] zahlen = [1, 2, 3, 4, 5, 6];
for (int i = 0; i < zahlen.Length; i++) //Auf die Länge des Arrays zugreifen, um dynamisch die Schleife anzupassen auf das Array
{
	Console.WriteLine(zahlen[i]); //Den Index benutzen in Kombination mit i
}

//Problem: Der Index kann manipuliert werden, und dadurch außerhalb des Arrays liegen
//Lösung: foreach-Schleife

//foreach-Schleife
//Diese Schleife hat keinen Zähler, sondern nur das Element selbst
//Die foreach-Schleife sollte immer der for-Schleife vorgezogen werden
foreach (int zahl in zahlen)
{
    Console.WriteLine(zahl);
}
#endregion

#region Enums
//Enum
//Liste von Konstanten
//Eigener Typ
//Hintergrund: Über eine Enumvariable können mögliche Zustände eingeschränkt werden

//Beispiel: Prüfen, ob heute Dienstag ist
string tag = "Di";
if (tag == "Dienstag")
{

}

//Problem: In einem String darf alles enthalten sein
//Lösung: Über ein Enum die möglichen Werte einschränken
Wochentag wt = Wochentag.Di;
if (wt == Wochentag.Di)
{
	//Jetzt ist Dienstag immer genau ein Zustand
}

//Weitere Enumfunktionen
//Zuweisung von Werten

//Die Enum Klasse
Wochentag[] tage = Enum.GetValues<Wochentag>();
foreach (Wochentag w in tage)
{
    Console.WriteLine(w);
    Console.WriteLine((int) w); //Die Zahl hinter dem Wochentag
}

//Enum.Parse: Text zu einem Enumwert konvertieren
Console.WriteLine(Enum.Parse<Wochentag>("Mo"));
Console.WriteLine(Enum.Parse<Wochentag>("4"));
#endregion

#region Switch
//Switch
//Montag bis Freitag: Wochentag, Samstag/Sonntag: Wochenende
Wochentag t = Wochentag.Fr;
if (t == Wochentag.Mo || t == Wochentag.Di || t == Wochentag.Mi || t == Wochentag.Do || t == Wochentag.Fr)
{
	Console.WriteLine("Wochentag");
}
else if (t == Wochentag.Sa || t == Wochentag.So)
{
    Console.WriteLine("Wochenende");
}
else
{
    Console.WriteLine("Fehler");
}

//Strg + . : Schnelloptionen anzeigen
switch (t)
{
	case Wochentag.Mo:
	case Wochentag.Di:
	case Wochentag.Mi:
	case Wochentag.Do:
	case Wochentag.Fr:
		Console.WriteLine("Wochentag");
		break;
	case Wochentag.Sa:
	case Wochentag.So:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Fehler");
		break;
}

//Boolescher Switch
switch (t)
{
	case >= Wochentag.Mo and <= Wochentag.Fr:
		Console.WriteLine("Wochentag");
		break;
	case Wochentag.Sa or Wochentag.So:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Fehler");
		break;
}
#endregion

//WICHTIG: Enums müssen am Ende der Datei definiert werden
enum Wochentag
{
	Mo = 1, Di, Mi, Do, Fr, Sa, So
}