using Rossoforge.Core.Pool;
using Rossoforge.Core.Services;
using UnityEngine;

namespace Rossoforge.Core.UI
{
    public interface IUIService : IService
    {
        T OpenPopup<T>(IPooledGameobjectData data, IPopupData popupData = null, Vector3 position = new(), Space relativeTo = Space.Self) where T : MonoBehaviour, IPopupView;
    }
}
