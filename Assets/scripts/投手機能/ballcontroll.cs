using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroll : MonoBehaviour
{
    public Bomb exp;
    public GameObject bomb;
    public bool hitBomb = false;
    public float timer = 0.0f;
    public GameTextes gamas;//試合関連スクリプト
    public bool pitch = false;//shootSwitchの弟みたいなやつ
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
        float z = Random.RandomRange(5.0f, 7.0f);
        float timeLimit = Random.RandomRange(0.8f, 1.2f);
        //投球動作
        if (((timer > timeLimit) & shootSwitch) & gamas.gameset == false && gamas.change == false && gamas.Wait == false)
        {

            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
            pitch = true;
        }
        else if (((timer > timeLimit * 2) & shootSwitch) & gamas.gameset == false && gamas.change == true && gamas.Wait == false)
        {

            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
            gamas.change = false;
            pitch = true;
        }
        if (pitch == false)
        {
            bomb.SetActive(true);
        } 

        if (shootSwitch)
        {
            timer += Time.deltaTime;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bat"&&((Input.GetKey(KeyCode.A)&&gamas.Inning2==0)))
        {
            BatAudio.PlayOneShot(BatSE);
            hitBomb = true;
        }
        if (collision.gameObject.tag == "Bat" && ((Input.GetMouseButton(1) && gamas.Inning2 == 1)))
        {
            BatAudio.PlayOneShot(BatSE);
            hitBomb = true;
        }
        else if (collision.gameObject.tag == "Bat")
        {
            BatAudio.PlayOneShot(BatSE);
            pitch = false;

        }
        else if (collision.gameObject.tag == "Strike")
        {
            pitch = false;

        }



    }

}