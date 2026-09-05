using System;
using UnityEngine;

namespace Rossoforge.Audio.DataConfig
{
    [Serializable]
    public class BypassSettings
    {
        [field: SerializeField]
        public bool Effects { get; private set; } = false;

        [field: SerializeField]
        public bool ListenerEffects { get; private set; } = false;

        [field: SerializeField]
        public bool ReverbZones { get; private set; } = false;
    }
}
