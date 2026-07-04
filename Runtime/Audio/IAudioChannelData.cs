namespace Rossoforge.Core.Audio
{
    public interface IAudioChannelData
    {
        void SetVolume(float newVolume);
        void SetMute(bool active);
    }
}
