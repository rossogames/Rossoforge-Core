using Rossoforge.Core.Services;
using UnityEngine;

namespace Rossoforge.Core.Audio
{
    public interface IAudioService : IService, IInitializable
    {
        void SetChannelVolume(AudioChannelData channel, float volume);
        void SetChannelMute(AudioChannelData channel, bool isMuted);
        void PlayOneShot(AudioConfigData config, Transform parent, Vector3 position, Space relativeTo);
    }
}
