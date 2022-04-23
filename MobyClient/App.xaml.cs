namespace MobyClient;

public partial class App : Application {

	public App () {

		InitializeComponent ();

		ThemeHelper.SetTheme ();

		MainPage = Config.IsDesktop ? new DesktopShell () : new MobileShell ();

		Routing.RegisterRoute (nameof (PageDashboard), typeof (PageDashboard));
	}
}