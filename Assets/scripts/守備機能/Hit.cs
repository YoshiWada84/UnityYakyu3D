using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioSource HitAudio;
    public AudioClip HitSE;
    public GameTextes gamas;

    public ballcontroll ball;

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
            ball.out1 = false;
            ball.strike = false;
            ball.foul = false;
            ball.hit = true;
            ball.homerun = false;

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

            if (gamas.Inning2 == 0 && 4 <= gamas.Runner) 
            {
                gamas.AtkPt++;
                gamas.Runner = 3;

            }
            if (gamas.Inning2 == 1 && 4 <= gamas.Runner)
            {
                gamas.DefPt++;
                gamas.Runner = 3;
            }

        }
    }
}
