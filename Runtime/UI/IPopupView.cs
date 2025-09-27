namespace Rossoforge.Core.UI
{
    public interface IPopupView
    {
        string Name { get; }
        PopupState State { get; }
        bool AllowCancel { get; }

        void SetData(IPopupData popupData);
        bool CanBeOpened();
        bool CanBeClosed();
        void Close();
        void Open();
        void SetSortingOrder(int sortingOrder);

        void OnOpening();
        void OnActivate();
        void OnClosing();
        void OnDeactivate();
    }
}
