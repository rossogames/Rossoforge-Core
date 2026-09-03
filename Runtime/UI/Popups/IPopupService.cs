using Rossoforge.Core.Services;
using Rossoforge.Pool.DataConfig;
using Rossoforge.Pool.Service;
using UnityEngine;

namespace Rossoforge.Core.UI.Popups
{
    public interface IPopupService : IService
    {
        void CancelPopup();

        T OpenPopup<T>(IPooledGameobjectDataConfig data, IPopupData popupData = null, Vector3 position = new(), Space relativeTo = Space.Self, string poolCategory = IPoolService.DEFAULT_CATEGORY) where T : MonoBehaviour, IPopupView;
        Awaitable<T> OpenPopupUntilClosed<T>(IPooledGameobjectDataConfig data, IPopupData popupData = null, Vector3 position = new(), Space relativeTo = Space.Self, string poolCategory = IPoolService.DEFAULT_CATEGORY) where T : MonoBehaviour, IPopupView;

#if HAS_ADDRESSABLES
        Awaitable<T> OpenPopupUntilClosed<T>(IPooledObjectAsyncDataConfig data, IPopupData popupData = null, Vector3 position = new(), Space relativeTo = Space.Self, string poolCategory = IPoolService.DEFAULT_CATEGORY) where T : MonoBehaviour, IPopupView;
        Awaitable<T> OpenPopup<T>(IPooledObjectAsyncDataConfig data, IPopupData popupData = null, Vector3 position = new(), Space relativeTo = Space.Self, string poolCategory = IPoolService.DEFAULT_CATEGORY) where T : MonoBehaviour, IPopupView;
#endif
    }
}
