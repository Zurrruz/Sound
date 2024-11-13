using UnityEngine;

public class SoundMixerSlider : SoundParameters
{
    public void ChangeVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(_nameGroupMixer, Mathf.Log10(volume) * 20);
    }
}
