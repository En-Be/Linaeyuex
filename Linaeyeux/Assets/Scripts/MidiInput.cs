using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MidiInput : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void AdjustMainValue(InputAction.CallbackContext midivalue)
    {
        float ccVal = midivalue.ReadValue<float>();
        Debug.Log("MainValue = " + ccVal);
        gameManager.AdjustMainValue(ccVal);
    }
}
