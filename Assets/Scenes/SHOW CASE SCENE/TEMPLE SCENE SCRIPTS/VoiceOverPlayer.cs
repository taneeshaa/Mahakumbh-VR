using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VoiceOverPlayer : MonoBehaviour
{
    [Header("Voice over")]
    public AudioClip voiceOverClip;

    [Header("Input actions")]
    public InputActionProperty leftHandVoiceInputAction;
    public InputActionProperty rightHandVoiceInputAction;

    AudioManager audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("entered");
            PlayVoiceOver();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("exited");
            StopVoiceOver();
        }
    }


    #region Voice Over play Functionality
    public void PlayVoiceOver()
    {
        audioManager.voiceClipPlayFunction(voiceOverClip);
    }
    public void StopVoiceOver()
    {
        audioManager.voiceClipStopFunction();
    }
    #endregion

}