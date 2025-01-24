using M014;

namespace M014_Tests;

/// <summary>
/// View -> Text Explorer
/// Rechtsklick auf Dependencies -> Add Project Reference
/// 
/// W�hrend der Entwicklung Tests schreiben, um m�glichst viel Code zu testen
/// Regelm��ig alle Tests ausf�hren, um Fehler im Code fr�hzeitig zu erkennen
/// Tests sollten m�glichst simpel sein
/// </summary>
[TestClass]
public class RechnerTests
{
	private Rechner r;

	[TestInitialize]
	public void Startup() => r = new Rechner();

	[TestCleanup]
	public void Cleanup() => r = null;

	//////////////////////////////////////////////

	[TestMethod]
	[TestCategory("Addiere")]
	public void TesteAddiere()
	{
		double ergebnis = r.Addieren(4, 5);
		Assert.AreEqual(9, ergebnis);
	}

	[TestMethod]
	public void TesteSubtrahiere()
	{
		double ergebnis = r.Subtrahieren(4, 5);
		Assert.AreEqual(-1, ergebnis);
	}
}