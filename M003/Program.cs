#region Arrays
//Array: Variable, welche mehrere Werte halten kann
//Alle Werte müssen den gleichen Typen haben

int[] zahlen = new int[10]; //Array erstellen mit Länge 10 (Index 0-9). Jede Stelle hat den Standardwert (bei int: 0)
zahlen[0] = 10; //Wert einfügen
Console.WriteLine(zahlen[0]); //Wert entnehmen

//Direkte Initialisierung
zahlen = new int[] { 1, 2, 3, 4, 5 }; //Hier keine Größe angeben
zahlen = new[] { 1, 2, 3, 4, 5 };
int[] zahlen2 = { 1, 2, 3, 4, 5 };
int[] zahlen3 = [1, 2, 3, 4, 5]; //Ab .NET 8

//Funktionen

//Length: Gibt die Anzahl der Plätze im Array aus
Console.WriteLine(zahlen2.Length); //5

//Contains: Prüft, ob ein bestimmter Wert im Array enthalten ist
zahlen.Contains(3); //Ist 3 im Array enthalten?
Console.WriteLine(zahlen.Contains(3));
#endregion

#region Bedingungen
//If-Bedingung
//Führt Code nur aus, wenn die Bedingung gültig ist

//Vergleichsoperatoren
//==, != (gleich, ungleich)
//>, <= (größer, kleiner-gleich)
//<, >= (kleiner, größer-gleich)

string hallo = "Hallo";
string welt = "Welt";
//if (hallo > welt) { } //Nicht möglich
//if (hallo.Length > welt.Length) { } //Längen vergleichen ist möglich

//Logische Operatoren
//&& (und)
//|| (oder)
//! (nicht)
//^ (exklusiv-oder, XOR)

int z1 = 5;
int z2 = 8;
int z3 = 12;

//Aufgabe: z1 soll überprüft werden, ob sie größer als die anderen beiden Zahlen ist
if (z1 > z2 && z1 > z3)
{
	//Hier müssen beide Bedingungen gültig sein
}

if (z1 > z2 || z1 > z3)
{
	//Hier muss mind. eine Bedingung gültig sein (links, rechts, beide)
}

if (z1 > z2 ^ z1 > z3)
{
	//Hier muss eine der beiden Bedingungen gültig sein (aber nicht beide)
}

//Not (!)
if (zahlen.Contains(10))
{
	//Prüft, ob 10 enthalten ist
}

if (!zahlen.Contains(10))
{
	//Prüft, ob 10 NICHT enthalten ist
}

if (!(z1 > z2)) { }
if (z1 <= z2) { }

//If, Else
//If: Wenn die Bedingung wahr ist
//Else: Wenn die Bedingung nicht wahr ist
if (z1 > z2)
{
	//...
}
else //!(z1 > z2)
{
	//...
}

if (z1 > z2)
{

}
else if (z1 == z2)
{

}

//Einzeilige Blöcke können in C# ohne Klammern dargestellt werden

if (z1 > z2)
{
    Console.WriteLine("z1 ist größer als z2");
}


if (z1 > z2)
	Console.WriteLine("z1 ist größer als z2");
#endregion