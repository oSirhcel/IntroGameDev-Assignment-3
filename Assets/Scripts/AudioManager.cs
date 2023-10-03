using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip introBGM;
    public AudioClip gameBGM;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null && introBGM != null)
        {
            audioSource.clip = introBGM;
            audioSource.Play();
            Invoke("PlayLoopingClip", introBGM.length);  // Schedule the PlayLoopingClip method to be called after the first clip ends.
        }
    }

    void PlayLoopingClip()
    {
        if (audioSource != null && gameBGM != null)
        {
            audioSource.clip = gameBGM;
            audioSource.loop = true;  // Set the audio source to loop.
            audioSource.Play();
        }
    }
}