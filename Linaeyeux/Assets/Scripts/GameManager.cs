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
    private List<Objet> selectedObjets = new List<Objet>();
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

    public void HoldingCanvas(Vector2 pos)
    {
        //Set destination
        Debug.Log("Holding canvas");
    }

    public void TappedCanvas(Vector2 pos)
    {
        Debug.Log("TappedCanvas");

        if(selectedObjets.Count != 0)
        {
            selectedObjets.Clear();
        }
        else
        {
            GameObject newObjet = Instantiate(objetPrefab, pos, transform.rotation);
            newObjet.transform.localScale = new Vector3(objetSize,objetSize,objetSize);
            float r = Random.Range(0.0f,360.0f);
            newObjet.transform.Rotate(0.0f, 0.0f, r, Space.Self);
            Objet thisObjet = newObjet.GetComponent<Objet>();
            thisObjet.gameManager = this;
            objets.Add(thisObjet);
        }
    }

    public void HoldingObjet(Objet objet)
    {
        Debug.Log("Holding objet");
        if(selectedObjets.Contains(objet))
        {
            selectedObjets.Remove(objet);
        }
        else
        {
            selectedObjets.Add(objet);
        }
    }

    public void TappedObjet(Objet objet)
    {
        Debug.Log("Tapped objet");
        objet.Tapped();
    }

    public void ObjetDestroyed(Objet o)
    {
        objets.Remove(o);
    }

    public void AdjustMainValue(float f)
    {
        objetSize = f;
        Debug.Log("value = " + f);
        if(selectedObjets.Count != 0)
        {
            foreach(Objet o in selectedObjets)
            {
                o.UpdateSize(objetSize);
            }
        }
        else
        {
            foreach(Objet o in objets)
            {
                o.UpdateSize(objetSize);
            }
        }
    }
}
