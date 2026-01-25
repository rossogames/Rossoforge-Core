namespace Rossoforge.Core.UI.Screens
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
