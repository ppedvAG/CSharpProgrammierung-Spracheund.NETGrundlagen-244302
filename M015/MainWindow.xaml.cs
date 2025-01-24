using System.Windows;

namespace M015;

public partial class MainWindow : Window
{
	private int Counter;

	public MainWindow()
	{
		InitializeComponent();

		Dropdown.ItemsSource = Enumerable.Range(0, 20);
		LB.ItemsSource = Enumerable.Range(0, 10);
	}

	/// <summary>
	/// Events
	/// Schnittstelle, welche uns ermöglicht, an internen Code eigenen Code anzuhängen
	/// 
	/// Entwickler stellen eine Schnittstelle bereit (z.B. Click beim Button)
	/// Wir als Benutzer können an diese Schnittstelle eigenen Code anhängen
	/// Wenn intern das Event gefeuert wird, wird unser Code ausgeführt
	/// </summary>
	private void Button_Click(object sender, RoutedEventArgs e)
	{
		new MainWindow().Show();
		return;

		Counter++;
		//Output.Text = Counter.ToString();

		//Output.Text = Dropdown.SelectedItem.ToString();

		MessageBoxResult res = MessageBox.Show("Möchtest du den eingegebenen Text anzeigen?", "Text anzeigen", MessageBoxButton.YesNo, MessageBoxImage.Question);
        if (res == MessageBoxResult.Yes)
		{
			Output.Text = Input.Text;
		}
	}
}