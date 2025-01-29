using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange1P : MonoBehaviour
{
    public GameTextes gamas;
    public GameObject P1;
    public GameObject P2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color color = new Color(1.0f, 1.0f, 0.0f, 1.0f);
        Color color2 = new Color(1.0f, 1.0f, 1.0f, 1.0f);


        
        if (gamas.Inning2 == 0)
        {
            P1.gameObject.GetComponent<RawImage>().color = color;
            P2.gameObject.GetComponent<RawImage>().color = color2;
        }
        else if (gamas.Inning2 == 1)
        {
            P1.gameObject.GetComponent<RawImage>().color = color2;
            P2.gameObject.GetComponent<RawImage>().color = color;
        }
    }
}
