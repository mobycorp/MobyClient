namespace MobyClient.ViewModels;

public class ShellViewModel {

    #region Constructors

    public ShellViewModel () {

        Dashboard = new AppSection {
            TargetType = typeof (PageDashboard),
            Title = AppResources.PageDashboard
        };
    }

    #endregion

    #region Properties

    public AppSection Dashboard { get; set; }

    #endregion

    #region Methods

    #endregion

    #region Fields

    #endregion
}