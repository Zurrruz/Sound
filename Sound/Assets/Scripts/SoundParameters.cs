using UnityEngine;
using UnityEngine.Audio;

public class SoundParameters : MonoBehaviour
{
    [SerializeField] protected AudioMixerGroup _mixer;
    [SerializeField] protected string _nameGroupMixer;

    protected float _maxVolume = 0;
    protected float _minVolume = -80;
}
