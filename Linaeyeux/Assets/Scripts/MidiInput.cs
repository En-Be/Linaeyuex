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

    public void OnAdjustMainValue(InputValue midivalue)
    {
        float ccVal = midivalue.Get<float>();
        Debug.Log("MainValue = " + ccVal);
        gameManager.AdjustMainValue(ccVal);
    }

}
