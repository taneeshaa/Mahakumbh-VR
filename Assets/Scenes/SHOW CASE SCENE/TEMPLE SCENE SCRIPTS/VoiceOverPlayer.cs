using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VoiceOverPlayer : MonoBehaviour
{
    [Header("Voice over")]
    public AudioClip voiceOverClip;
    //public GameObject panel;

    [Header("Input actions")]
    public InputActionProperty leftHandVoiceInputAction;
    public InputActionProperty rightHandVoiceInputAction;

    AudioManager audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    #region Voice Over play Functionality
    public void EnableHologramAndPlayInstruction()
    {
        if (leftHandVoiceInputAction.action.WasPressedThisFrame())
        {
            audioManager.voiceClipPlayFunction(voiceOverClip);
        }
    }
    public void DisableHologramAndStopInstruction()
    {
        if (leftHandVoiceInputAction.action.WasReleasedThisFrame())
        {
            audioManager.voiceClipStopFunction();

        }
    }
    #endregion

}
