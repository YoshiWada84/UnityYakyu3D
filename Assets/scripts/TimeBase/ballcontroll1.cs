using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroll1 : MonoBehaviour
{
    public Bomb1 exp;
    public GameObject bomb;
    public bool hitBomb = false;
    public float timer = 0.0f;
    public GameTimeBase gamas;//試合関連スクリプト
    public bool pitch = false;//shootSwitchの弟みたいなやつ
    public static bool shootSwitch;


    public bool strike = false;
    public bool out1 = false;
    public bool foul = false;
    public bool hit = false;
    public bool homerun = false;

    public bool hitter = false;//baghantei

    public float z = 0;
    public float timeLimit = 0;
    // Use float timeLimitthis for initialization
    void Start()
    {
        
        Rigidbody rigid = GetComponent<Rigidbody>();
        shootSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        z = Random.RandomRange(2.0f, 3.0f);
        timeLimit = Random.RandomRange(0.5f, 1.5f);
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
        if (collision.gameObject.tag == "Bat"&&((Input.GetKey(KeyCode.A)&&gamas.Inning2==0)))
        {
            hitter = true;
            hitBomb = true;
        }
        if (collision.gameObject.tag == "Bat" && ((Input.GetMouseButton(1) && gamas.Inning2 == 1)))
        {
            hitter = true;
            hitBomb = true;
        }
        else if (collision.gameObject.tag == "Bat")
        {
            hitter = true;
            //pitch = false;

        }
        else if (collision.gameObject.tag == "Strike")
        {
            pitch = false;
            strike = true;
            out1 = false;
            foul = false;
            hit = false;
            homerun = false;
        }
        else if (collision.gameObject.tag == "Out")
        {

            out1 = true;
            strike = false;
            
            foul = false;
            hit = false;
            homerun = false;

        }
        else if (collision.gameObject.tag == "Foul")
        {

            foul = true;
            strike = false;
            out1 = false;
            
            hit = false;
            homerun = false;

        }
        else if (collision.gameObject.tag == "Hit")
        {
           
            hit = true;
            strike = false;
            out1 = false;
            foul = false;
           
            homerun = false;

        }
        else if (collision.gameObject.tag == "Homerun")
        {

            homerun = true;
            strike = false;
            out1 = false;
            foul = false;
            hit = false;
           
        }



    }
    
}