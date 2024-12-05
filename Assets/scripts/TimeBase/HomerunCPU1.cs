using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomerunCPU1 : MonoBehaviour
{
    public AudioSource HitAudio;
    public AudioClip HitSE;
    public GameTimeBase gamas;

    public batTBCPU cpus;
    public batTBCPU1 cpus2;

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
            cpus.hit = false;
            cpus2.hit = false;


            gamas.Strike = 0;
            if (gamas.Inning2 == 0)
            {
                gamas.Team1Batter++;
                gamas.AtkPt += gamas.Runner + 1;
                gamas.Runner = 0;
            }
            if (gamas.Inning2 == 1)
            {
                gamas.Team2Batter++;
                gamas.DefPt+= gamas.Runner + 1;
                gamas.Runner = 0;
            }
        }
    }
}
