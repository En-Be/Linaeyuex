using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet : MonoBehaviour
{
    private Camera cam;
    public GameManager gameManager;
    private float spawnTime;
    private float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        spawnTime = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lifeTime = Time.time - spawnTime;
        // Debug.Log("Been alive for " + lifeTime);
        float r = Random.Range(-10.0f,10.0f);
        transform.Rotate(0.0f, 0.0f, r, Space.Self);
        transform.Translate(Vector2.up * Time.deltaTime);
        CheckIfOnScreen();
    }

    void CheckIfOnScreen()
    {
        // Debug.Log("Screen width = " + Screen.width);
        // Debug.Log("Screen height = " + Screen.height);
        // Debug.Log("Objet x pos = " + transform.position.x);
        // Debug.Log("Objet y pos = " + transform.position.y);
        Vector2 screenPos = cam.WorldToScreenPoint(transform.position);
        // Debug.Log("Converted to screen x pos = " + screenPos.x);
        // Debug.Log("Converted to screen y pos = " + screenPos.y);
        if(screenPos.x < 0 || screenPos.x > Screen.width || screenPos.y < 0 || screenPos.y > Screen.height)
        {
            Debug.Log("offscreen");
            gameManager.ObjetDestroyed();
            Destroy(gameObject);
        }
    }

    public void Tapped()
    {
        if(lifeTime > 0.5f)
        {
            Debug.Log("Destroying");
            gameManager.ObjetDestroyed();
            Destroy(gameObject);
        }
    }
}
