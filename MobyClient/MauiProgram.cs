namespace MobyClient;

public static class MauiProgram {

	public static MauiApp CreateMauiApp () {

		var builder = MauiApp.CreateBuilder ();

		_ = builder
			.UseMauiApp<App> ()
			.ConfigureFonts (fonts => {
				_ = fonts.AddFont ("Font Awesome 6 Brands-Regular-400.otf", "FaBrands");
				_ = fonts.AddFont ("Font Awesome 6 Duotone-Solid-900.otf", "FaDuotone");
				_ = fonts.AddFont ("Font Awesome 6 Pro-Light-300.otf", "FaLight");
				_ = fonts.AddFont ("Font Awesome 6 Pro-Regular-400.otf", "FaRegular");
				_ = fonts.AddFont ("Font Awesome 6 Pro-Solid-900.otf", "FaSolid");
				_ = fonts.AddFont ("Font Awesome 6 Pro-Thin-100.otf", "FaThin");
				_ = fonts.AddFont ("OpenSans-Regular.ttf", "OpenSansRegular");
				_ = fonts.AddFont ("Segoe-Ui-Bold.ttf", "SegoeUiBold");
				_ = fonts.AddFont ("Segoe-Ui-Regular.ttf", "SegoeUiRegular");
				_ = fonts.AddFont ("Segoe-Ui-Semibold.ttf", "SegoeUiSemibold");
				_ = fonts.AddFont ("Segoe-Ui-Semilight.ttf", "SegoeUiSemilight");
			});

		//Get the application builder so we can add services to the mix...
		var app = builder.Build ();

		// Set the global Maui App object.
		ApplicationControl.MauiApp = app;

		return app;
	}
}