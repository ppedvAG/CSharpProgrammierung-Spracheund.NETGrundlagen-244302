namespace M006.Data;

/// <summary>
/// - Trainer
/// - Teilnehmer
/// - Ausstattung
/// - Location
/// - Schulungstyp
/// - Dauer
/// - Titel
/// - ...
/// </summary>
public class Schulung
{
	public Person Trainer { get; set; }

	public Person[] Teilnehmer { get; private set; }

	public string Standort { get; set; }

	public Schulungstyp Typ { get; set; }

	public int DauerInTagen { get; set; }

	public string Titel { get; set; }

	//Strg + . auf den Klassennamen -> Generate Constructor
	public Schulung(string titel, int dauerInTagen, Person trainer, Schulungstyp typ, string standort, params Person[] teilnehmer)
	{
		Titel = titel;
		DauerInTagen = dauerInTagen;
		Trainer = trainer;
		Typ = typ;
		Standort = standort;
		Teilnehmer = teilnehmer;
	}

	public void NeueTeilnehmerHinzufuegen(params Person[] teilnehmer)
	{
		Teilnehmer = Teilnehmer.Concat(teilnehmer).ToArray();
	}
}