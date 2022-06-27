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
    private Vector2 lastTouchPos;

    void Start()
    {
        cam = Camera.main;
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void OnTouchingScreen(InputValue pressedValue)
    {
        Vector2 pos = pressedValue.Get<Vector2>();
        if(pos != Vector2.zero)
        {
            lastTouchPos = ConvertToWorldSpace(pos);
            // Debug.Log("lastTouchPos = " + lastTouchPos);
        }
    }

    public void OnHoldingScreen()
    {
        // Debug.Log("screen held");
        GameObject g = MakeARay();
        if (g.name == "TouchPlane")
        {
            gameManager.HoldingCanvas(lastTouchPos);
        }
        else
        {
            gameManager.HoldingObjet(g.GetComponent<Objet>());
        }
    }

    public void OnTappedScreen()
    {
        // Debug.Log("Screen tapped");
        GameObject g = MakeARay();
        if (g.name == "TouchPlane")
        {
            gameManager.TappedCanvas(lastTouchPos);
        }
        else
        {
            gameManager.TappedObjet(g.GetComponent<Objet>());
        }
    }

    Vector2 ConvertToWorldSpace(Vector2 touch)
    {
        Vector2 point = cam.ScreenToWorldPoint(new Vector3(touch.x, touch.y));
        return point;
    }

    private GameObject MakeARay()
    {
        // Debug.Log("making a ray");
        RaycastHit2D hit = Physics2D.Raycast(lastTouchPos, Vector2.zero);
        return hit.collider.gameObject;
    }
}
