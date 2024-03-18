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

    public void OnTriggerEnter()
    {
        PlayVoiceOver();
    }

    public void OnTriggerExit()
    {
        StopVoiceOver();
    }

    #region Voice Over play Functionality
    public void PlayVoiceOver()
    {
        if (leftHandVoiceInputAction.action.WasPressedThisFrame() && rightHandVoiceInputAction.action.WasReleasedThisFrame())
        {
            audioManager.voiceClipPlayFunction(voiceOverClip);
        }
    }
    public void StopVoiceOver()
    {
        if (leftHandVoiceInputAction.action.WasReleasedThisFrame() && rightHandVoiceInputAction.action.WasReleasedThisFrame())
        {
            audioManager.voiceClipStopFunction();

        }
    }
    #endregion

}
