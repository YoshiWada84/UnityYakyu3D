using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ballcontroll : MonoBehaviour
{
    public Bomb exp;
    public GameObject bomb;
    public bool hitBomb = false;
    public float timer = 0.0f;
    public GameTextes gamas;//試合関連スクリプト
    public bool pitch = false;//shootSwitchの弟みたいなやつ
    public static bool shootSwitch;

    public bool strike = false;
    public bool out1 = false;
    public bool foul = false;
    public bool hit = false;
    public bool homerun = false;


    public bool hitter = false;//baghantei
    // Use this for initialization
    void Start()
    {
        
        Rigidbody rigid = GetComponent<Rigidbody>();
        shootSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        float z = Random.RandomRange(2.0f, 3.0f);
        float timeLimit = Random.RandomRange(1.1f, 1.1f);
        //投球動作
        if (((timer > timeLimit) & shootSwitch) & gamas.gameset == false && gamas.change == false && gamas.Wait == false)
        {
            bomb.SetActive(true);
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
            pitch = true;

            strike = false;
            out1 = false;
            foul = false;
            hit = false;
            homerun = false;
        }
        else if (((timer > timeLimit * 2) & shootSwitch) & gamas.gameset == false && gamas.change == true && gamas.Wait == false)
        {
            bomb.SetActive(true);
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
            gamas.change = false;
            pitch = true;
        }
        else
        {
            pitch = false;
        }

        if (strike == true || out1 == true || foul == true || hit == true || homerun == true)
        {
            hitter = false;
        }
       

        if (shootSwitch)
        {
            gamas.hithit = 0;
            timer += Time.deltaTime;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Bat"&&(Input.GetKey(KeyCode.A)&&gamas.Inning2==0))
        {
            hitter = true;
            hitBomb = true;
        }
        else if (collision.gameObject.tag == "Bat")
        {
            hitter = true;
            //pitch = false;

        }
        



    }

}