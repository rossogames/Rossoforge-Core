using RossoForge.Core.Services;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace RossoForge.Core.Addressables
{
    public interface IAddressableService : IService
    {
        bool IsLoaded(string address);
        bool IsLoaded(string containerKey, string address);

        Awaitable<T> LoadAsync<T>(string address) where T : Object;
        Awaitable<T> LoadAsync<T>(string containerKey, string address) where T : Object;

        Awaitable<T> LoadAsync<T>(AssetReferenceT<T> assetReference) where T : Object;
        Awaitable<T> LoadAsync<T>(string containerKey, AssetReferenceT<T> assetReference) where T : Object;

        void Release(string address);
        void Release(string containerKey, string address);

        void ReleaseAll();
        void ReleaseAll(string containerKey);
    }
}
