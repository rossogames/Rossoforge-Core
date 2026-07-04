using Rossoforge.Core.Services;

namespace Rossoforge.Core.Audio
{
    public interface IAudioService : IService, IInitializable
    {
        void SetChannelVolume(IAudioChannelData channel, float volume);
        void SetChannelMute(IAudioChannelData channel, bool isMuted);
    }
}
