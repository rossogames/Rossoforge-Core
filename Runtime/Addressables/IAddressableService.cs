using Rossoforge.Core.Services;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Rossoforge.Core.Addressables
{
    public interface IAddressableService : IService
    {
        bool IsLoaded(string address);
        bool IsLoaded(string containerKey, string address);

        Awaitable<T> LoadAssetAsync<T>(string address) where T : Object;
        Awaitable<T> LoadAssetAsync<T>(string containerKey, string address) where T : Object;

        Awaitable<T> LoadAssetAsync<T>(AssetReferenceT<T> assetReference) where T : Object;
        Awaitable<T> LoadAssetAsync<T>(string containerKey, AssetReferenceT<T> assetReference) where T : Object;

        Awaitable<IList<T>> LoadAssetsAsync<T>(string label, System.Action<T> callback = null) where T : Object;
        Awaitable<IList<T>> LoadAssetsAsync<T>(string containerKey, string label, System.Action<T> callback = null) where T : Object;

        void Release(string address);
        void Release(string containerKey, string address);

        void ReleaseAll();
        void ReleaseAll(string containerKey);
    }
}
