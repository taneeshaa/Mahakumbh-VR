using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Player")]
    public AudioSource voiceOverPlayer;

    public void voiceClipPlayFunction(AudioClip clip)
    {
        voiceOverPlayer.PlayOneShot(clip);
    }
    public void voiceClipStopFunction()
    {
        voiceOverPlayer.Stop();
    }
}