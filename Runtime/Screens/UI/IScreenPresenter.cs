namespace Rossoforge.Screens.UI
{
    public interface IScreenPresenter
    {
        ScreenState State { get; }

        void OnOpening();
        void OnActivate();
        void OnClosing();
        void OnDeactivate();
    }
}
