using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ballcontroll : MonoBehaviour
{
    public Bomb exp;//�Ō�����
    public GameObject bomb;//��������
    public bool hitBomb = false;//����������
    public float timer = 0.0f;//�����܂ł̎���
    public GameTextes gamas;//�����֘A�X�N���v�g
    public bool pitch = false;//shootSwitch�̒�݂����Ȃ��
    public static bool shootSwitch;//

    //�ŋ�����
    public bool strike = false;//�X�g���C�N
    public bool out1 = false;//�A�E�g
    public bool foul = false;//�t�@�[��
    public bool hit = false;//�q�b�g
    public bool homerun = false;//�z�[������


    public bool hitter = false;//�Ō�����
    // Use this for initialization
    void Start()
    {
        
        Rigidbody rigid = GetComponent<Rigidbody>();
        shootSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        float z = Random.RandomRange(2.0f, 3.0f);//����
        float timeLimit = Random.RandomRange(0.8f, 1.3f);//�����܂ł̎���
        //��������
        if (((timer > timeLimit) & shootSwitch) & gamas.gameset == false && gamas.change == false && gamas.Wait == false)//����
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
        else if (((timer > timeLimit * 2) & shootSwitch) & gamas.gameset == false && gamas.change == true && gamas.Wait == false)//����
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

        if (strike == true || out1 == true || foul == true || hit == true || homerun == true)//�ŋ�����
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