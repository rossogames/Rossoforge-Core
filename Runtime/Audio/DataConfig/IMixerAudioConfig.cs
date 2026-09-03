using UnityEngine.Audio;

namespace Rossoforge.Audio.DataConfig
{
    public interface IMixerAudioConfig
    {
        AudioMixerGroup MixerGroup { get; }
    }
}
