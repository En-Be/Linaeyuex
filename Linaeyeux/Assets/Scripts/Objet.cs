using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet : MonoBehaviour
{
    public GameManager gameManager;
    private Camera cam;
    private float spawnTime;
    private float lifeTime;

    private float size;
    private float sizeMin;
    private float sizeMax;

    void Start()
    {
        cam = Camera.main;
        spawnTime = Time.time;
    }

    void FixedUpdate()
    {
        lifeTime = Time.time - spawnTime;
        float r = Random.Range(-10.0f,10.0f);
        transform.Rotate(0.0f, 0.0f, r, Space.Self);
        transform.Translate(Vector2.up * Time.deltaTime);
        CheckIfOnScreen();
    }

    public void UpdateSize(float f)
    {
        Vector3 newSize = new Vector3(f,f,f);
        transform.localScale = newSize;
        // float newValue = (f - sizeMin) / (sizeMax - sizeMin) * 100;
        // Debug.Log();
    }

    void CheckIfOnScreen()
    {
        Vector2 screenPos = cam.WorldToScreenPoint(transform.position);
        if(screenPos.x < 0 || screenPos.x > Screen.width || screenPos.y < 0 || screenPos.y > Screen.height)
        {
            RemoveObjet();
        }
    }

    public void Tapped()
    {
        if(lifeTime > 0.5f)
        {
            RemoveObjet();
        }
    }

    public void RemoveObjet()
    {
        Debug.Log("Destroying");
        gameManager.ObjetDestroyed(this);
        Destroy(gameObject);
    }
}
