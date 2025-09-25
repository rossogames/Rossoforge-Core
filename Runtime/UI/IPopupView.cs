namespace Rossoforge.Core.UI
{
    public interface IPopupView
    {
        PopupState State { get; }

        void SetData(IPopupData popupData);
        bool CanBeOpened();
        bool CanBeClosed();
        void Close();
        void Open();

        void OnOpening();
        void OnActivate();
        void OnClosing();
        void OnDeactivate();
    }
}
