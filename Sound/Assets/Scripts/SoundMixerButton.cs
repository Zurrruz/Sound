public class SoundMixerButton : SoundParameters
{
    public void ToggleMusic(bool enable)
    {
        if (enable)
            _mixer.audioMixer.SetFloat(_nameGroupMixer, _minVolume);
        else
            _mixer.audioMixer.SetFloat(_nameGroupMixer, _maxVolume);        
    }
}
