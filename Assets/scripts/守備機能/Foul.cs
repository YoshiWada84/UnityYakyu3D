using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foul : MonoBehaviour
{
    public AudioSource FoulAudio;
    public AudioClip FoulSE;
    public GameTextes gamas;
    
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
