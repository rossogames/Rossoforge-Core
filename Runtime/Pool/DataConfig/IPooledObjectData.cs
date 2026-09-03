namespace Rossoforge.Pool.DataConfig
{
    public interface IPooledObjectData
    {
        string name { get; }
        int MaxSize { get; }
    }
}