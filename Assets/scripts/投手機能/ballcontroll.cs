using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ballcontroll : MonoBehaviour
{
    public Bomb exp;//打撃爆発
    public GameObject bomb;//投球爆発
    public bool hitBomb = false;//爆発したか
    public float timer = 0.0f;//投球までの時間
    public GameTextes gamas;//試合関連スクリプト
    public bool pitch = false;//shootSwitchの弟みたいなやつ
    public static bool shootSwitch;//
    public bool pitch2 = false;//shootSwitchの弟みたいなやつ2

    //打球判定
    public bool strike = false;//ストライク
    public bool out1 = false;//アウト
    public bool foul = false;//ファール
    public bool hit = false;//ヒット
    public bool homerun = false;//ホームラン

    public GameObject Camera3;//3塁カメラ
    public GameObject Camera1;//1塁カメラ


    public bool hitter = false;//打撃判定
    // Use this for initialization
    void Start()
    {
        
        Rigidbody rigid = GetComponent<Rigidbody>();
        shootSwitch = true;
        pitch2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        float z = Random.RandomRange(2.0f, 3.0f);//球速
        float timeLimit = Random.RandomRange(0.8f, 1.4f);//投球までの時間

        

        //投球動作
        if (((timer > timeLimit) & shootSwitch) & gamas.gameset == false && gamas.change == false && gamas.Wait == false)//投球
        {
            bomb.SetActive(true);
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
            pitch2 = false;
            pitch = true;

            strike = false;
            out1 = false;
            foul = false;
            hit = false;
            homerun = false;
        }
        else if (((timer > timeLimit * 3) & shootSwitch) & gamas.gameset == false && gamas.change == true && gamas.Wait == false)//投球
        {
            bomb.SetActive(true);
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
            pitch2 = false;
            gamas.change = false;
            pitch = true;
        }
        else
        {
            pitch = false;
        }

        if (strike == true || out1 == true || foul == true || hit == true || homerun == true)//打球処理
        {
            hitter = false;

            Camera3.SetActive(true);
            Camera1.SetActive(true);
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
            Camera3.SetActive(false);
            Camera1.SetActive(false);
        }
        else if (collision.gameObject.tag == "Bat")
        {
            hitter = true;
            //pitch = false;

            Camera3.SetActive(false);
            Camera1.SetActive(false);
        }
        



    }

}