using M006.Data;

namespace M006;

/// <summary>
/// Klassen und Objekte
/// 
/// Objekte sind Datenstrukturen, welche Daten halten
/// Jedes Objekt kommt aus einer Klasse
/// Die Klasse hinter den Objekten gibt den Aufbau der Objekte vor
/// 
/// int: Ganze Zahl
/// double: Gleitkommazahl
/// string: Text
/// Person: ?
/// 
/// Um komplexe Datentypen darzustellen (u.a. Person) benötigen wir Klassen
/// Die Klasse ist ein Bauplan für Objekte. In der Klasse werden nur Definitionen angelegt
/// Generell werden Klassen in zwei Typen unterteilt: Datenklassen und Funktionsklassen
/// 
/// Person ist eine Datenklasse mit bestimmten Eigenschaften
/// - Größe - double
/// - Alter - int
/// - Vorname - string
/// - Nachname - string
/// - ...
/// 
/// WICHTIG: In der Klasse werden keine konkreten Werte definiert
/// Aus der Klasse können beliebig viele Objekte erzeugt werden
/// Die konkreten Werte werden in den Objekten definiert
/// Objekt p1: [180cm, 25J, Max, Mustermann]
/// Objekt p2: [175cm, 20J, Udo, Mustermann]
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		//Objekt erstellen mithilfe des new-Keywords
		Person p1 = new Person();
		//Hier soll jetzt die Person konkrete Werte bekommen
		p1.SetVorname("Max"); //Set Methode aufrufen
		p1.Nachname = "Mustermann"; //Property kann einfach per = zugewiesen werden
		p1.Alter = 25;

		//Mit Vorname, Nachname Konstruktor
		Person p2 = new Person("Max", "Mustermann");
		p2.Alter = 30;

		Person p3 = new Person("Max", "Mustermann", 40);
        Console.WriteLine(p3.VollerName);

		//Namespace
		//= Package
		//Organisationseinheiten, welche unsere Typen gruppieren können
		//Bei großen Projekten essentiell, um Ordnung zu halten
		//Mithilfe von namespace M006; werden alle Typen in der entsprechenden Datei in den Namespace M006

		//Person ist jetzt in M006.Data; hier muss jetzt eine Referenz erzeugt werden
		//Referenzen zu anderen Namespaces werden mit dem using Keyword erzeugt
		//using M006.Data; (Strg + .: Automatisch importieren)

		//Generell hängen Namespaces mit einer Ordnerstruktur zusammen

		//////////////////////////////////////////////////////////////////////////

		//Assozation
		//Objekte in andere Objekte verschachteln
		//Beispiel: Schulung
		Schulung s = new Schulung("C# Grundkurs", 4, p1, Schulungstyp.Gemischt, "Schulungsraum 1", p2, p3);
		s.NeueTeilnehmerHinzufuegen(new Person());
    }
}
