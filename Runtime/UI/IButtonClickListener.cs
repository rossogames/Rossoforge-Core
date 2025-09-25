namespace Rossoforge.Core.UI
{
    public interface IButtonClickListener<T>
    {
        void OnButtonClickInvoked(T eventArg);
    }
}
