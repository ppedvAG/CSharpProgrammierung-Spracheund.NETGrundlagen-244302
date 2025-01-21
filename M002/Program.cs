#region Variablen
//Kommentare
//Mit zwei Slashes kann ein Kommentar definiert werden
//Wird von Compiler ignoriert

/*
	Mehrzeilige 
	Kommentare
 */


//Variable
//Behälter für einen Wert
//Werden in der Programmierung immer benötigt
//In C# müssen Variablen aus 3 Teilen bestehen: Typen, Namen, Wert
//Aufbau: <Typ> <Name> = <Wert>;

int Zahl = 10; //Ab Zeile 7 kann die Variable Zahl angegriffen werden
Console.WriteLine(Zahl); //cw + Tab

Console.WriteLine(Zahl * 2); //Variable verwenden

//Datentypen
//Geben an, welchen Inhalt eine Variable haben darf

//Ganzzahlige Typen: int, long, short, byte
int i = 23;

long l = 23;

short s = 23;

byte b = 23;

//Kommazahlentypen: double, float, decimal
double kommazahl = 23.65;
Console.WriteLine(kommazahl * 2);

float f = 23.65f; //Jede Kommazahl in C# ist standardmäßig ein double, mit f am Ende kann eine Konvertierung durchgeführt werden

decimal d = 23.65m;

//String: Text
string str = "Hallo, ich bin ein String"; //WICHTIG: Strings müssen immer mit einem doppelten Hochkomma geöffnet und geschlossen werden
Console.WriteLine(str);

char c = 'a'; //char: Einzelnes Zeichen, wird immer mit einzelnen Hochkomma definiert

//Wahr-/Falschwert: bool
//Kann immer nur true oder false enthalten
bool wahr = true;
bool falsch = false;
#endregion

#region Strings
string ergebnis = "Die Zahl mal zwei ist: " + Zahl * 2; //Hier wird das Produkt berechnet und an den String angehängt
Console.WriteLine(ergebnis);

//String-Interpolation ($-String): Code in einen String einbauen
//Aufgabe: kommazahl, f, d in der Konsole in einer schönen Form ausgeben
Console.WriteLine("Der double ist: " + kommazahl + ", der float ist: " + f + ", der decimal ist: " + d);
Console.WriteLine($"Der double ist: {kommazahl}, der float ist: {f}, der decimal ist: {d}");

Console.WriteLine($"Die Zahl mal zwei ist: {Zahl * 2}");

//Escape-Sequenzen: Untippbare Zeichen in Strings einbetten
//https://learn.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170
Console.WriteLine("Zeilenumbruch \n Zeilenumbruch");

Console.WriteLine("Tabulator \t Tabulator");

//Verbatim-String: String, welcher Escape-Sequenzen ignoriert
Console.WriteLine(@"\n");

//Wird häufig für Pfade verwendet
string pfad = @"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.1\System.Security.AccessControl.dll";
#endregion

#region Eingabe
//Console.ReadLine(): Wartet auf die Eingabe des Benutzers, und speichert diese in die Variable (hier "eingabe")
//string eingabe = Console.ReadLine();
//Console.WriteLine($"Du hast {eingabe} eingegeben");

//Console.ReadKey(): Wartet auf eine einzelne Eingabe vom Benutzer
//ConsoleKeyInfo taste = Console.ReadKey();
//Console.WriteLine(taste.Key);
#endregion

#region Konvertierungen
//Konvertierung: Umwandlung von einem Typen zu einem anderen Typen

//Stringkonvertierungen
string userEingabe = Console.ReadLine();
//Console.WriteLine($"Deine Zahl mal Zwei ist: {userEingabe * 2}");
//Problem: Strings können nicht mit zwei Multipliziert werden
//Lösung: Text zu einer Zahl umwandeln

//String zu Zahl umwandeln: Parse
int konvertierung = int.Parse(userEingabe); //Die Parse Funktion versucht den Text in eine Zahl umzuwandeln
Console.WriteLine($"Deine Zahl mal Zwei ist: {konvertierung * 2}");

//Zahl zu String umwandeln: ToString()
Console.WriteLine(10.ToString());
Console.WriteLine(konvertierung.ToString());

//Zahl zu Zahl: Typecast, Cast, Casting
double grosseZahl = 219487192374.28;
int x = (int) grosseZahl; //Mit (<Typ>) eine Typkonvertierung erzwingen
Console.WriteLine(x);

int y = 20;
double z = y; //Implizite Konvertierung
Console.WriteLine(z);
#endregion

#region Arithmetik
int zahl1 = 4;
int zahl2 = 7;

//Aufgabe: zahl2 auf zahl1 aufaddieren
//zahl1 + zahl2; //+ alleine berechnet nur eine Summe
zahl1 += zahl2;
Console.WriteLine(zahl1);

//Wenn wir + alleine benutzen wollen, benötigen wir eine Variable
int summe = zahl1 + zahl2;
Console.WriteLine(summe);

//Modulo (%): Rest einer Division
Console.WriteLine(8 % 5); //3R

//++, --: +1, -1
zahl1++; //Erhöhe zahl1 um 1
zahl1--;

//Math: Mathematische Funktionen
double gerundet = Math.Round(3.456263214, 2); //Auf X Kommastellen runden
Console.WriteLine(gerundet);

//Divisionsprobleme
Console.WriteLine(8 / 5); //1, wenn zwei ints dividiert werden, kommt auch ein int heraus
Console.WriteLine(8 / 5.0); //Wenn eine der beiden Zahlen eine Kommazahl ist, kommt auch eine Kommazahl heraus
Console.WriteLine(8 / 5d);
Console.WriteLine(8f / 5);
Console.WriteLine((double) zahl1 / zahl2); //Eine der beiden Zahlen casten
#endregion