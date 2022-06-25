using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

// using UnityEngine.InputSystem;


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
        // for (int i = 0; i < Input.touchCount; ++i)
        // {   
        //     Touch touch = Input.GetTouch(i);
        //     // Debug.Log("Touch x = " + touch.position.x);
        //     // Debug.Log("Touch y = " + touch.position.y);

        //     if (touch.phase == TouchPhase.Began)
        //     {
        //         Debug.Log("Touch began at " + touch.position);
        //         MakeARay(touch);
        //     }
        // }
    }

    public void OnPressed(InputValue pressedValue)
    {
        Vector2 pos = pressedValue.Get<Vector2>();
        if(pos != Vector2.zero)
        {
            pos = cam.ScreenToWorldPoint(new Vector3(pos.x, pos.y));
            Debug.Log("pos = " + pos);
            gameManager.ScreenTapped(pos);
        }
    }

    // public void Tap(InputAction.CallbackContext tap)
    // {
    //     Vector2 tapValue = tap.ReadValue<Vector2>();
    //     Debug.Log("tapValue.x = " + tapValue.x);
    //     Debug.Log("tapValue.y = " + tapValue.y);
    //     // gameManager.AdjustMainValue(ccVal);
    // }

//     Vector2 ConvertToWorldSpace(Touch touch)
//     {
//         Vector2 point = cam.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y));
//         // Debug.Log("Touch x = " + point.x);
//         // Debug.Log("Touch y = " + point.y);
//         return point;
//     }

//     private void MakeARay(Touch touch)
//     {
//         Debug.Log("making a ray");
//         Vector2 rayOrigin = ConvertToWorldSpace(touch);
//         RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.zero);

//         if (hit.collider.gameObject.name == "TouchPlane")
//         {
//             print("Hit the touchplane");
//             gameManager.ScreenTapped(rayOrigin);
//         }
//         else
//         {
//             print("Hit an objet");
//             gameManager.ObjetTapped(hit.collider.gameObject);
//         }
//     }
}
