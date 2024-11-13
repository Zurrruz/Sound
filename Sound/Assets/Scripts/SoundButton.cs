using UnityEngine;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void ToggleMusic(bool enable)
    {
        if (enable)
            _audioSource.Play();
        else
            _audioSource.Stop();
    }
}
