using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    public AudioSource OutAudio;
    public AudioClip OutSE;
    public GameTextes gamas;
    // Start is called before the first frame update
    void Start()
    {
        OutAudio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (3 <= gamas.Inning)
        {
            transform.localScale = new Vector3(10, 7, 1);
        }
        else
        {
            transform.localScale = new Vector3(7, 5, 1);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            gamas.Strike=0;
            gamas.Out++;

            OutAudio.PlayOneShot(OutSE);
            
        }
    }
}
