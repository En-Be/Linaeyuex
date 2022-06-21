using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject objet;
    private int objetCount;

    [SerializeField]
    private TextMeshProUGUI objetCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objetCounter.text = "Objet count = " + objetCount.ToString();

    }

    public void ScreenTapped(Vector2 v)
    {
        GameObject thisObjet = Instantiate(objet, v, transform.rotation);
        float r = Random.Range(0.0f,360.0f);
        thisObjet.transform.Rotate(0.0f, 0.0f, r, Space.Self);
        thisObjet.GetComponent<Objet>().gameManager = this;
        objetCount++;
    }

    public void ObjetDestroyed()
    {
        objetCount--;
    }
}
