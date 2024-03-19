using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class LoadScene : MonoBehaviour
{
    [Header("Input actions")]
    public InputActionProperty leftHandVoiceInputAction;
    public InputActionProperty rightHandVoiceInputAction;

    public void Update()
    {
        if (leftHandVoiceInputAction.action.WasPressedThisFrame() || rightHandVoiceInputAction.action.WasReleasedThisFrame())
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void LoadScenee(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
