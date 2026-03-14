using Rossoforge.Core.Services;

namespace Rossoforge.Core.UserData
{
    public interface IUserDataService<T> : IService, IInitializable where T : IGameSave, new()
    {
        T CurrentSave { get; }

        void Save();
        void Load();
        void Delete();
    }
}
