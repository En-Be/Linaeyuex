using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MidiInput : MonoBehaviour
{
    private GameManager gameManager;

    private float mainValuePrevious;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void OnAdjustMainValue(InputValue midiValue)
    {
        float f = midiValue.Get<float>();
        
        if(mainValuePrevious < f)
        {
            gameManager.AdjustMainValue(f);
        }
        else
        {
            gameManager.AdjustMainValue(f * -1);
        }
        mainValuePrevious = f;

        // float ccVal = midivalue.Get<float>();
        // Debug.Log("MainValue = " + ccVal);
        // gameManager.AdjustMainValue(ccVal);
    }

    public void OnSelectFirstScale(InputValue midiValue)
    {
        Debug.Log("Selecting first scale");
    }

}
