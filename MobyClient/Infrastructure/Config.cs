namespace MobyClient.Infrastructure;

internal class Config {

	#region Constructors

	#endregion

	#region Properties

	public static bool IsDesktop {
		get {
#if WINDOWS || MACCATALYST
            return true;
#else
			return false;
#endif
		}
	}

	#endregion

	#region Methods

	#endregion

	#region Fields

	#endregion
}