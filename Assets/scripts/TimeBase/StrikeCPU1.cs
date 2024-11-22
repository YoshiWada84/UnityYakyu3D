using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeCPU1 : MonoBehaviour
{
    public AudioSource OutAudio;
    public AudioClip OutSE;
    public GameTimeBase gamas;

    public batTBCPU cpus;
    public batTBCPU1 cpus2;
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
            cpus.hit = false;
            gamas.Strike++;
            OutAudio.PlayOneShot(OutSE);
        }
    }
}
