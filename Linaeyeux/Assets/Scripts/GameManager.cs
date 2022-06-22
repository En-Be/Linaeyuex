using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject objetPrefab;

    [SerializeField]
    private List<Objet> objets = new List<Objet>();
    [SerializeField]
    private TextMeshProUGUI objetCounter;

    private float objetSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objetCounter.text = "Objet count = " + objets.Count.ToString();
    }

    public void ScreenTapped(Vector2 v)
    {
        GameObject newObjet = Instantiate(objetPrefab, v, transform.rotation);
        newObjet.transform.localScale = new Vector3(objetSize,objetSize,objetSize);
        float r = Random.Range(0.0f,360.0f);
        newObjet.transform.Rotate(0.0f, 0.0f, r, Space.Self);
        Objet thisObjet = newObjet.GetComponent<Objet>();
        thisObjet.gameManager = this;
        objets.Add(thisObjet);
    }

    public void ObjetTapped(GameObject objet)
    {
        objet.GetComponent<Objet>().Tapped();
    }

    public void ObjetDestroyed(Objet o)
    {
        objets.Remove(o);
    }

    public void AdjustMainValue(float f)
    {
        objetSize = f;
        foreach(Objet o in objets)
        {
            o.UpdateSize(objetSize);
        }
    }
}
