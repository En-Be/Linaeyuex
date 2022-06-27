using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet : MonoBehaviour
{
    public GameManager gameManager;
    private Camera cam;
    private float spawnTime;
    private float lifeTime;

    public float sizeMin;
    public float sizeMax;

    public float speed;

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
        transform.Translate(Vector2.up * (Time.deltaTime * speed));
        CheckIfOnScreen();
    }

    public void UpdateSize(float f)
    {
        // float adjustment = transform.localScale.x + f;
        Vector3 adjustedSize = new Vector3(f,f,f);
        transform.localScale += adjustedSize;
        // float clampedValue = Mathf.Clamp(transform.localScale.x, sizeMin, sizeMax);
        // Vector3 clampedSize = new Vector3(clampedValue,clampedValue,clampedValue);
        // transform.localScale = clampedSize;
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
