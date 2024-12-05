using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeCPU : MonoBehaviour
{
    public AudioSource OutAudio;
    public AudioClip OutSE;
    public GameTextes gamas;

    public batCPU cpus;
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
