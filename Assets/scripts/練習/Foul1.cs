using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foul1 : MonoBehaviour
{
    public AudioSource FoulAudio;
    public AudioClip FoulSE;
    public GameTextes1 gamas;


    public ballcontroll1 ball;

    // Start is called before the first frame update
    void Start()
    {
        FoulAudio = gameObject.GetComponent<AudioSource>();
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
            ball.foul = true;
            ball.hit = false;
            ball.homerun = false;
            FoulAudio.Stop();
            FoulAudio.PlayOneShot(FoulSE);
            if (2<=gamas.Strike )
            {

            }
            else
            {
                gamas.Strike++;
            }
        }
    }
}
