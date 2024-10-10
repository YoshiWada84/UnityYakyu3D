using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homerun : MonoBehaviour
{
    public AudioSource HitAudio;
    public AudioClip HitSE;
    public GameTextes gamas;
    // Start is called before the first frame update
    void Start()
    {
        HitAudio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            HitAudio.Stop();
            HitAudio.PlayOneShot(HitSE);
            gamas.Strike = 0;
            if (gamas.Inning2 == 0)
            {
                gamas.AtkPt += gamas.Runner + 1;
                gamas.Runner = 0;
            }
            if (gamas.Inning2 == 1)
            {
                gamas.DefPt+= gamas.Runner + 1;
                gamas.Runner = 0;
            }
        }
    }
}
