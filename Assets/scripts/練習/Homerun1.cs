using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homerun1 : MonoBehaviour
{
    public AudioSource HitAudio;
    public AudioClip HitSE;
    public GameTextes1 gamas;

    public ballcontroll1 ball;
    
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
            ball.out1 = false;
            ball.strike = false;
            ball.foul = false;
            ball.hit = false;
            ball.homerun = true;


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
