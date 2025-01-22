namespace M006;

/// <summary>
/// - Vorname - string
/// - Nachname - string
/// - Größe - double
/// - Alter - int
/// </summary>
public class Person
{
	#region Feld
	/// <summary>
	/// Feld
	/// Dieses Feld hält einen Wert (hier Vorname)
	/// Felder sollten nur indirekt angegriffen werden können
	/// Durch den private Modifier kann das Feld nicht von außerhalb der Klasse angegriffen werden
	/// 
	/// Beispiel: Verhindern, dass der User hier beliebige Texte eintragen kann (z.B. Zahlen)
	/// </summary>
	private string vorname;

	/// <summary>
	/// Die Get-Methode wird verwendet, um den Wert aus einem Feld auszulesen
	/// </summary>
	public string GetVorname()
	{
		return vorname;
	}

	/// <summary>
	/// Die Set-Methode wird verwendet, um neue Werte in das Feld einzutragen
	/// Hier kann der User daran gehindert werden, ungültige Werte einzutragen
	/// Die Set-Methode ist immer void und hat immer einen Parameter der mit dem dahinterliegenden Feld übereinstimmt
	/// </summary>
	public void SetVorname(string vorname)
	{
		//this: Wird verwendet, um gleichnamige Variablen voneinander zu unterscheiden
		//this.vorname bezieht sich auf das Feld weiter oben
		//vorname bezieht sich auf den Parameter innerhalb dieser Methode
		if (vorname.All(char.IsLetter) && vorname.Length >= 2 && vorname.Length <= 15)
			this.vorname = vorname;
		else
            Console.WriteLine($"{vorname} ist kein gültiger Vorname");
    }
	#endregion

	#region Property
	/// <summary>
	/// Property
	/// Vereinfachung von dem alten Get-/Setmethoden Schema
	/// Verwendet eine kompakte Syntax
	/// </summary>
	private string nachname;

	/// <summary>
	/// Full Property
	/// Das Full Property ist ein Property mit einem privaten Feld + einem public Property mit get und set Accessoren
	/// </summary>
	public string Nachname
	{
		//get
		//{
		//	return nachname;
		//}

		get => nachname;
		set
		{
			//Für den Parameter der Set-Methode gibt es hier ein Keyword: value
			//value ist hier der neue Wert, welcher vom User gesetzt wird
			if (value.All(char.IsLetter) && value.Length >= 2 && value.Length <= 15)
				nachname = value;
			else
				Console.WriteLine($"{value} ist kein gültiger Nachname");
		}
	}

	/// <summary>
	/// Get-Only Property
	/// Ein Get-Only Property kann nicht gesetzt
	/// Es ist nur dafür da, einen Wert zu erzeugen (bestehend aus anderen Werten)
	/// </summary>
	public string VollerName
	{
		get
		{
			return vorname + " " + nachname;
		}
	}

	public string VollerName2
	{
		get => vorname + " " + nachname;
	}

	public string VollerName3 => vorname + " " + nachname;

	/// <summary>
	/// Auto-Property
	/// Property, welches kein Feld dahinter hat
	/// Gleiche Funktionsweise wie eine Variable
	/// Verwendungen:
	/// - private set, kann von außen gelesen aber nicht beschrieben werden
	/// - Json, XML: Felder werden beim Serialisieren nicht berücksichtigt -> Properties
	/// - WPF/MAUI: Bindings
	/// - ...
	/// </summary>
	public int Alter { get; set; }
	#endregion

	#region Konstruktor
	/// <summary>
	/// Konstruktor
	/// "Main Methode" von der Klasse
	/// Wird bei Erstellung von dem Objekt ausgeführt
	/// Der Standardkonstruktor existiert immer, wenn kein anderer Konstruktor definiert ist
	/// </summary>
	public Person()
	{
        Console.WriteLine("Person erstellt");
    }

	/// <summary>
	/// Hier können jetzt Standardwerte bei Initialisierung übergeben werden
	/// </summary>
	public Person(string vorname, string nachname) : this()
	{
		this.vorname = vorname;
		this.nachname = nachname;
    }

	/// <summary>
	/// Verkettung von Konstruktoren
	/// Mithilfe von this(...) können Konstruktoren miteinander verkettet werden
	/// D.h. wenn dieser Konstruktor ausgeführt wird, wird auch der Konstruktor in der Kette darüber ausgeführt
	/// </summary>
	public Person(string vorname, string nachname, int alter) : this(vorname, nachname)
	{
		//this.vorname = vorname;
		//this.nachname = nachname;
		this.Alter = alter;
	}
	#endregion
}