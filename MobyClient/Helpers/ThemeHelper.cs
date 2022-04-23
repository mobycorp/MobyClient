namespace MobyClient.Helpers;

public static class ThemeHelper {

    public static void SetTheme () {

        Application.Current.UserAppTheme = SettingsHelper.Theme switch {
			AppTheme.Dark => AppTheme.Dark,
			_ => AppTheme.Light,
		};
    }
}