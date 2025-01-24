using Newtonsoft.Json;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace M013;

/// <summary>
/// Dateiverwaltung
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		//Grundlegende Klassen
		//Path, Directory, File

		//Aufgabe: Ordner erstellen, und in diesen eine Datei ablegen, mit dem Inhalt "Hallo Welt"

		//1. Pfad + Ordner erstellen
		//Pfade werden als strings dargestellt
		string folderPath = "Test"; //Wenn ein relativer Pfad angelegt wird, bezieht sich dieser immer auf die .exe Datei der Anwendung selbst
		if (!Directory.Exists(folderPath))
		{
			Directory.CreateDirectory(folderPath);
		}

		//2. Pfad zur Datei + Datei erstellen
		string filePath = Path.Combine(folderPath, "Test.txt"); //Combine ist Plattformunabhängig (\ oder /)
		File.WriteAllText(filePath, "Hallo Welt");

		/////////////////////////////////////////////////////////////

		//Stream
		//Pipe zu einer externen Resource
		//Byte für Byte Daten schreiben/lesen
		//Basis für alle Kommunikation mit externen Resourcen

		//StreamWriter
		//Vereinfachung für den Basic Stream, welcher schreiben kann
		StreamWriter sw = new StreamWriter(filePath);
		sw.WriteLine("Hallo");
		sw.WriteLine("Welt");
		//Streams sind Pipes, diese haben einen Buffer
		//Dieser Buffer muss niedergeschrieben werden
		sw.Flush(); //Flush() schreibt den Buffer in das File
		sw.Close(); //Die Close() Methode gibt den Zugriff auf das File wieder frei

		//StreamReader
		//Vereinfachung für den Basic Stream, welcher lesen kann
		StreamReader sr = new StreamReader(filePath);
		List<string> zeilen = new();
		while (!sr.EndOfStream)
			zeilen.Add(sr.ReadLine());
		sr.Close();

		//using-Block
		//Am Ende des Blocks wird der Stream automatisch geschlossen
		//Bei allen Klassen, welche mit externen Resourcen interagieren, kann der using-Block verwendet werden
		//Beispiele: StreamWriter/Reader, HttpClient, DbConnection, ...
		using (StreamWriter sw2 = new StreamWriter(filePath))
		{
			sw2.WriteLine("Hallo2");
			sw2.WriteLine("Welt2");
		}

		//using-Statement
		//Funktioniert wie der using-Block, wird aber erst am Ende der Methode geschlossen
		using StreamWriter sw3 = new StreamWriter(filePath);
		sw3.WriteLine("Hallo3");
		sw3.WriteLine("Welt3");

		/////////////////////////////////////////////////////////////

		//JSON & XML
		//Serialisierungsformate um Objekte aus dem Programm zu bewegen (speichern, senden, ...)
		//Wird zw. mehreren Geräten/Anwendungen verwendet, damit diese kommunizieren können

		//Json
		//In C# gibt es 2 große Json-Frameworks
		//System.Text.Json (intern)
		//Newtonsoft.Json (extern)

		//System.Text.Json
		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		string jsonPath = Path.Combine(folderPath, "Test.json");

		//JsonSerializerOptions options = new(); //Optionen setzen, beim schreiben/lesen von Json
		//options.WriteIndented = true; //Json schön schreiben

		//string json = JsonSerializer.Serialize(fahrzeuge, options); //WICHTIG: Hier options mitgeben
		//File.WriteAllText(jsonPath, json);

		//string readJson = File.ReadAllText(jsonPath);
		//Fahrzeug[] readFzg = JsonSerializer.Deserialize<Fahrzeug[]>(readJson);

		//Newtonsoft.Json
		//Externe Pakete installieren
		//= Code von anderen Entwicklern in unser Projekt einbinden und verwenden
		//Tools -> NuGet-Package Manager
		JsonSerializerSettings options = new(); //Optionen setzen, beim schreiben/lesen von Json
		options.Formatting = Newtonsoft.Json.Formatting.Indented; //Json schön schreiben

		string json = JsonConvert.SerializeObject(fahrzeuge, options); //WICHTIG: Hier options mitgeben
		File.WriteAllText(jsonPath, json);

		string readJson = File.ReadAllText(jsonPath);
		Fahrzeug[] readFzg = JsonConvert.DeserializeObject<Fahrzeug[]>(readJson);

		//XML
		string xmlPath = Path.Combine(folderPath, "Test.xml");
		XmlSerializer xml = new XmlSerializer(fahrzeuge.GetType());
		using (StreamWriter xmlWriter = new(xmlPath))
		{
			xml.Serialize(xmlWriter, fahrzeuge);
		}

		using (StreamReader xmlReader = new(xmlPath))
		{
			List<Fahrzeug> readFzg2 = xml.Deserialize<List<Fahrzeug>>(xmlReader); //(List<Fahrzeug>) xml.Deserialize(xmlReader);
		}
	}
}

[DebuggerDisplay("Marke: {Marke}, MaxV: {MaxV}")]
public class Fahrzeug
{
	public int MaxV { get; set; }

	public FahrzeugMarke Marke { get; set; }

	public Fahrzeug(int maxV, FahrzeugMarke marke)
	{
		MaxV = maxV;
		Marke = marke;
	}

    public Fahrzeug() { }
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}

public static class XmlExtensions
{
	public static T Deserialize<T>(this XmlSerializer xml, TextReader s)
	{
		return (T) xml.Deserialize(s);
	}
}