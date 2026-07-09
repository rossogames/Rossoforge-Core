using UnityEngine.Audio;

namespace Rossoforge.Core.Audio
{
    public interface IMixerAudioConfig
    {
        AudioMixerGroup MixerGroup { get; }
    }
}
