using UnityEngine;

namespace Rossoforge.Core.Components
{
    public class DontDestroyRoot : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}