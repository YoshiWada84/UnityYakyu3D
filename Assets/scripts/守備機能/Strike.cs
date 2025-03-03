using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour
{
    public AudioSource OutAudio;
    public AudioClip OutSE;
    public GameTextes gamas;
    public ballcontroll ball;

    // Start is called before the first frame update
    void Start()
    {
        OutAudio = gameObject.GetComponent<AudioSource>();
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
            ball.strike = true;
            ball.foul = false;
            ball.hit = false;
            ball.homerun = false;
            gamas.Strike++;
            OutAudio.PlayOneShot(OutSE);
        }
    }
}
