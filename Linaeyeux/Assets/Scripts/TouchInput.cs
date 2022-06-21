using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchInput : MonoBehaviour
{
    private Camera cam;
    private GameManager gameManager;

    void Start()
    {
        cam = Camera.main;
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {   
            Touch touch = Input.GetTouch(i);
            Debug.Log("Touch x = " + touch.position.x);
            Debug.Log("Touch y = " + touch.position.y);

            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch began at " + touch.position);
                gameManager.ScreenTapped(ConvertToWorldSpace(touch));
            }
        }
    }

    Vector2 ConvertToWorldSpace(Touch touch)
    {
        Vector2 point = cam.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y));
        return point;
    }
}
