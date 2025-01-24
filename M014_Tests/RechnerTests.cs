using M014;

namespace M014_Tests;

/// <summary>
/// View -> Text Explorer
/// Rechtsklick auf Dependencies -> Add Project Reference
/// 
/// Während der Entwicklung Tests schreiben, um möglichst viel Code zu testen
/// Regelmäßig alle Tests ausführen, um Fehler im Code frühzeitig zu erkennen
/// Tests sollten möglichst simpel sein
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