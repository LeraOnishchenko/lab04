namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Tools.Navigation
{
    internal enum ViewType
    {
        DbList
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);

        void DeNavigate(ViewType viewType);
    }
}
