namespace RossoForge.Core.Pool
{
    public interface IPooledObjectData
    {
        string name { get; }
        int MaxSize { get; }
    }
}