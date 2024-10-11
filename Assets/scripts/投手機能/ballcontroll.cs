using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroll : MonoBehaviour
{
    private float timer = 0.0f;
    public GameTextes gamas;//�����֘A�X�N���v�g
    private float timeLimit = 2.0f;
    public static bool shootSwitch;
    public AudioSource BatAudio;
    public AudioClip BatSE;
    // Use this for initialization
    void Start()
    {
        BatAudio = gameObject.GetComponent<AudioSource>();
        Rigidbody rigid = GetComponent<Rigidbody>();
        shootSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {

        //��������
        if (((timer > timeLimit) & shootSwitch)&gamas.gameset==false)
        {
            float z = 3; // force strength;
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
        }

        if (shootSwitch)
        {
            timer += Time.deltaTime;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bat")
        {
            
            BatAudio.PlayOneShot(BatSE);
        }


    }
}