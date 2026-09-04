using Rossoforge.Audio.DataConfig;
using Rossoforge.Services.Service;
using UnityEngine;

namespace Rossoforge.Audio.Service
{
    public interface IAudioService : IService
    {
        void SetChannelVolume(AudioChannelDataConfig channel, float volume);
        void SetChannelMute(AudioChannelDataConfig channel, bool isMuted);
        void PlayOneShot(AudioDataConfig config, Transform parent, Vector3 position, Space relativeTo);
    }
}
