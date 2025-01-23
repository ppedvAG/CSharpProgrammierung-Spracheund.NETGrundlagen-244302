namespace M009;

public abstract class Lebewesen
{
	public int Alter { get; set; }

	/// <summary>
	/// Die Bewegen Methode gibt hier selbst keinen Code mehr vor
	/// </summary>
	public abstract void Bewegen(int distanz);

	public Lebewesen(int alter)
	{
		Alter = alter;
	}
}
