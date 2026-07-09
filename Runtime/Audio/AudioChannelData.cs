using System;
using UnityEngine;

namespace Rossoforge.Core.Audio
{
    [CreateAssetMenu(fileName = nameof(AudioChannelData), menuName = "Rossoforge/Audio/Audio Channel Data")]
    public class AudioChannelData : ScriptableObject
    {
        public event Action<float> OnVolumeChanged;
        public event Action<bool> OnMutedChanged;

        private float _volume = 1;
        private bool _isMuted = false;

        public float Volume
        {
            get => _volume;
            set
            {
                value = Mathf.Clamp01(value);

                if (Mathf.Approximately(Volume, value))
                    return;

                _volume = value;
                OnVolumeChanged?.Invoke(value);
            }
        }

        public bool IsMuted
        {
            get => _isMuted;
            set
            {
                if (IsMuted == value)
                    return;

                _isMuted = value;
                OnMutedChanged?.Invoke(value);
            }
        }
    }
}
