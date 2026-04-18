using WillowMaze.App.Services;

namespace WillowMaze.App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var serverUrl = Preferences.Default.Get("WillowServerUrl", "wss://192.168.100.160:19751/ws");
		TapRelayClient.Configure(serverUrl);
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		var window = new Window(new MainPage()) { Title = "Willow Maze" };
		window.Created += (_, _) =>
		{
			StatusReporter.StartTimer(window.Dispatcher);
		};
		return window;
	}
}
