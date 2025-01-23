namespace M011;

/// <summary>
/// Generischer Datentyp (Generic)
/// 
/// Platzhalter für einen konkreten Typen
/// Platzhalter wird generell als "T" bezeichnet
/// Wenn hier ein konkreter Typ eingesetzt wird, werden alle Vorkommnisse von T mit diesem Typen ausgetauscht
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		//List
		//Kann eine beliebige Menge an Daten halten
		//Flexibler als ein Array
		//Der generische Datentyp (in der spitzen Klammer) gibt den Datentyp, welcher in der Liste gespeichert werden kann
		List<int> list = new List<int>();
		list.Add(1); //Hier wird das T durch int ersetzt
		list.Add(2);
		list.Add(3);
		list.Add(4);
		list.Add(5);

		//Liste iterieren wie ein Array
		foreach (int i in list)
		{
            Console.WriteLine(i);
        }

		//Index wie bei Array
		Console.WriteLine(list[1]);

		if (list.Contains(3))
		{
			//...
		}

		List<string> str = new List<string>();
		str.Add("A"); //Hier wird das T durch string ersetzt
		str.Add("B");
		str.Add("C");
		str.Add("D");
		str.Add("E");
		str.Add("F");

		/////////////////////////////////////////////////////////////////
		
		//Dictionary
		//Liste von Schlüssel-Wert-Paaren
		//Einträge, welche einen Schlüssel haben
		//Jeder Schlüssel hat einen angehängten Wert
		//Das Dictionary hat zwei Generics (1: Schlüssel, 2: Wert)
		Dictionary<string, int> einwohnerzahlen = new(); //Target-Typed New
		einwohnerzahlen.Add("Wien", 2_000_000);
		einwohnerzahlen.Add("Berlin", 3_650_000);
		einwohnerzahlen.Add("Paris", 2_160_000);

		//WICHTIG: Schlüssel müssen eindeutig sein
		//einwohnerzahlen.Add("Paris", 2_160_000); //ArgumentException

		if (einwohnerzahlen.ContainsKey("Wien"))
			Console.WriteLine(einwohnerzahlen["Wien"]); //Wert hinter Schlüssel entnehmen

		//var: Typen automatisch erkennen und einsetzen
		//Mit Strg + . durch den konkreten Typen ersetzen
		foreach (KeyValuePair<string, int> kv in einwohnerzahlen)
		{
            Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner.");
			//Console.WriteLine(kv.Key);
			//Console.WriteLine(kv.Value);
		}
	}
}
