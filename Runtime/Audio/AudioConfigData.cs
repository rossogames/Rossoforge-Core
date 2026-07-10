using System;
using UnityEngine;

namespace Rossoforge.Core.Audio
{
    public abstract class AudioConfigData : ScriptableObject
    {
        public event Action OnPlayRequested;
        public event Action OnStopRequested;

        [field: SerializeField]
        public AudioChannelData Channel { get; private set; }

        [field: SerializeField]
        public MainSettings Main { get; private set; }

        /// <summary>
        /// Triggers a global request to play this audio configuration. 
        /// All active <see cref="StaticAudioHandler"/> instances in the scene utilizing this asset will react and play simultaneously.
        /// </summary>
        public void Play()
        {
            OnPlayRequested?.Invoke();
        }

        /// <summary>
        /// Triggers a global request to stop this audio configuration. 
        /// All active <see cref="StaticAudioHandler"/> instances in the scene utilizing this asset will react and stop playing simultaneously.
        /// </summary>
        public void Stop()
        {
            OnStopRequested?.Invoke();
        }
    }
}
