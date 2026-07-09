using System;
using UnityEngine;

namespace Rossoforge.Core.Audio
{
    [Serializable]
    public class SpatialSettings
    {
        [field: Range(0f, 1f)]
        [field: SerializeField]
        public float SpatialBlend { get; private set; } = 0f;

        [field: Range(-1f, 1f)]
        [field: SerializeField]
        public float StereoPan { get; private set; } = 0f;

        [field: Range(0f, 1.1f)]
        [field: SerializeField]
        public float ReverbZoneMix { get; private set; } = 1f;

        [field: Range(0f, 5f)]
        [field: SerializeField]
        public float DopplerLevel { get; private set; } = 1f;

        [field: Range(0f, 360f)]
        [field: SerializeField]
        public float Spread { get; private set; } = 0f;

        [field: SerializeField]
        public AudioRolloffMode RolloffMode { get; private set; } = AudioRolloffMode.Logarithmic;

        [field: SerializeField]
        public float MinDistance { get; private set; } = 1f;

        [field: SerializeField]
        public float MaxDistance { get; private set; } = 500f;
    }
}
