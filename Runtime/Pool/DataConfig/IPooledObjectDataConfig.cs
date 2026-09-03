namespace Rossoforge.Pool.DataConfig
{
    public interface IPooledObjectDataConfig
    {
        string name { get; }
        int MaxSize { get; }
    }
}