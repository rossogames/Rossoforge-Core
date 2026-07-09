using System;
using UnityEngine;

namespace Rossoforge.Core.Audio
{
    [Serializable]
    public class MainSettings
    {
        [field: SerializeField]
        public AudioClip Clip { get; private set; }

        [field: Range(0f, 1f)]
        [field: SerializeField]
        public float Volume { get; private set; } = 1f;

        [field: Range(-3f, 3f)]
        [field: SerializeField]
        public float Pitch { get; private set; } = 1f;

        [field: SerializeField]
        public bool Mute { get; private set; } = false;

        [field: SerializeField]
        public bool Loop { get; private set; } = false;

        [field: SerializeField]
        public bool Autoplay { get; private set; } = false;
    }
}
