using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCPU1 : MonoBehaviour
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
            cpus.hit = false;
            cpus2.hit = false;

            HitAudio.Stop();
            HitAudio.PlayOneShot(HitSE);
            if (gamas.Inning2 == 0)
            {
                gamas.Team1Batter++;
            }
            else if (gamas.Inning2 == 1)
            {
                gamas.Team2Batter++;
            }

            gamas.Strike = 0;
            gamas.Runner++;

            if (gamas.Inning2 == 0 && 2 <= gamas.Runner) 
            {
                gamas.AtkPt++;
                gamas.Runner = 1;

            }
            if (gamas.Inning2 == 1 && 2 <= gamas.Runner)
            {
                gamas.DefPt++;
                gamas.Runner = 1;
            }

        }
    }
}
