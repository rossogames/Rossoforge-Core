using UnityEngine;

namespace Rossoforge.Core.Audio
{
    public abstract class AudioConfigData : ScriptableObject
    {
        [field: SerializeField]
        public AudioChannelData Channel { get; private set; }

        [field: SerializeField]
        public MainSettings Main { get; private set; }
    }
}
