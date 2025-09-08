using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTextes : MonoBehaviour
{
    public GameObject bat1;//�o�b�g
    public GameObject bat1yowai;//�o�b�g��
    public GameObject bat1L;//�o�b�g��

    public GameObject bat2;//�o�b�g
    public GameObject bat2yowai;//�o�b�g��
    public GameObject bat2L;//�o�b�g��

    public GameObject Bakugeki;//����
    public ballcontroll Ball;//�{�[��
    public GameObject Runner1;//�����i�[
    public GameObject Runner2;//�����i�[
    public GameObject Runner3;//�����i�[

    public GameObject Runner4;//�����i�[
    public GameObject Runner5;//�����i�[
    public GameObject Runner6;//�����i�[

    public GameObject Ground1;//�O���E���h1
    public GameObject Ground2;//�O���E���h2
    public GameObject Ground3;//�O���E���h3

    public GameObject Def1;//����I�u�W�F�N�g1
    public GameObject Def2;//����I�u�W�F�N�g2


    public GameObject CText;//�`�F���W�e�L�X�g
    public GameObject CText2;//�`�F���W�e�L�X�g

    //BGM
    public GameObject BGM1;
    public GameObject BGM2;
    public GameObject BGM3;
    public GameObject BGM4;
    public GameObject BGM5;//�T���i������


    public Text InningText;     //��
    public Text AttackText;     //��U�`�[���̓��_
    public Text DeffenceText;   //��U�`�[���̓��_
    public Text RunnerText;     //�����i�[
    public Text StrikeText;     //�X�g���C�N�J�E���g
    public Text OutText;        //�A�E�g�J�E���g
    public Text ScoreText;        //�X�R�A�e�L�X�g
    public Text T1Text;        //�I��1�e�L�X�g
    public Text T2Text;        //�I��2�e�L�X�g
    public Text ChangeText;    //�`�F���W�e�L�X�g

    public int hour = 0;       //����
    public int min = 0;         //��
    public int sec = 0;         //�b

    public int sec2 = 0;         //�b

    public int hithit = 0;

    public int Inning;      //��
    public int Inning2;     //�\��
    public int Team1;       //�`�[����U
    public int Team2;       //�`�[����U
    public int Team1Batter;       //�`�[����U2
    public int Team2Batter;       //�`�[����U2
    

    public int AtkPt;       //��U�`�[���̓��_��
    public int DefPt;       //��U�`�[���̓��_��
    public int Runner;      //�����i�[
    public int Strike;      //�X�g���C�N��
    public int Out;         //�A�E�g�̐�
    public bool gameset;    //�����I�����ۂ�
    public bool change;    //�U����
    public bool Wait;      //�`�[������
    public bool game=false;      //9��ɂ��邩

    public bool Win;      //��
    public bool Lose;     //�s

    public EnterName Team3;
    public bool music5 = false;
    //BGM



    // Start is called before the first frame update
    void Start()
    {
        //�����֘A
        Inning = 1;
        Inning2 = 0;
        Team1 = 0;
        Team2 = 1;
        AtkPt = 0;
        DefPt = 0;
        Runner = 0;
        Strike = 0;
        Out = 0;
        Team1Batter = 1;
        Team2Batter = 1;
        gameset = false;
        change = false;
        Wait = true; 
        Ground1.gameObject.SetActive(true);
        Ground2.gameObject.SetActive(false);
        Ground3.gameObject.SetActive(false);
        Def1.gameObject.SetActive(true);
        Def2.gameObject.SetActive(false);

        CText.gameObject.SetActive(false);
        CText2.gameObject.SetActive(true);


        BGM1.gameObject.SetActive(true);
        BGM2.gameObject.SetActive(false);
        BGM3.gameObject.SetActive(false);
        BGM4.gameObject.SetActive(false);
        BGM5.gameObject.SetActive(false);
        music5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Alpha0))
        //{
        //    Ball.hitBomb = false;
        //    Bakugeki.gameObject.SetActive(true);
        //}
        if (Wait == true)
        {
            
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Title");

            }
            InningText.text = string.Format("");
            if (Team1==0)
            {
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(false);

            }
            else if (Team1 == 1)
            {
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(false);

            }
            else if (Team1 == 2)
            {
               
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                Ground3.gameObject.SetActive(false);
            }
            else if (Team1 == 3)
            {

                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);


            }
            else if (Team1 == 4)
            {

                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);


            }

            


        }
        if (Inning2 == 0 && Wait == false && gameset == false)
        {
            bat2yowai.SetActive(false);
            bat2.gameObject.SetActive(false);
            bat2L.gameObject.SetActive(false);
        }
        else if (Inning2 == 1 && Wait == false && gameset == false)
        {
            bat1yowai.SetActive(false);
            bat1.gameObject.SetActive(false);
            bat1L.gameObject.SetActive(false);
        }
        #region//�`�[��
        if (Inning2 == 0&&Wait==false&&gameset==false)
        {

            
            if (3 < Inning&&game==false)//��������(3��)
            {
                InningText.text = string.Format("����{0}��\", Inning);
            }
            else if (9 < Inning && game == true)//��������(9��)
            {
                InningText.text = string.Format("����{0}��\", Inning);
            }
            else//�C�j���O����(���̑�)
            {
                InningText.text = string.Format("{0}��\", Inning);
            }
            BGM2.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM3.gameObject.SetActive(false);
            BGM4.gameObject.SetActive(false);

        }
        
        if (Inning2 == 1&&Wait==false && gameset == false)
        {
            bat1.gameObject.SetActive(false);
            bat1L.gameObject.SetActive(false);
            if (3 < Inning&& game == false)//��������(3��)
            {
                InningText.text = string.Format("����{0}��", Inning);
            }
            else if (9 < Inning && game == true)//��������(9��)
            {
                InningText.text = string.Format("����{0}��", Inning);
            }
            else//�C�j���O����
            {
                InningText.text = string.Format("{0}��", Inning);
            }
            BGM3.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM2.gameObject.SetActive(false);
            BGM4.gameObject.SetActive(false);
            
        }
        
        if (Team1 == 0)
        {
            AttackText.text = string.Format("�G�g���[���I���F{0}", AtkPt);

            if (Inning2 == 1)
            {
                if ((game == true && Inning < 7) || (game == false && Inning < 4))
                {
                    T1Text.text = string.Format("P�@���̂�");
                }
                else
                {
                    T1Text.text = string.Format("P�@���܂�");
                }
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
               
                if ((game == true && 6 < Inning) || (game == false && 3 < Inning))
                {
                    bat1L.SetActive(false);
                    bat1.SetActive(true);
                    bat1yowai.SetActive(false);
                    T1Text.text = string.Format("{0}�@��܂���", Team1Batter);
                }
                else
                {
                    bat1L.SetActive(false);
                    bat1.SetActive(false);
                    bat1yowai.SetActive(true);
                    T1Text.text = string.Format("{0}�@�ق񂳂�", Team1Batter);
                }
                
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�ӂ�����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@��܂�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�Ȃ���", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�����΂�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�킾�@��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}�@�킾�@��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                if ((game == true && Inning < 7) || (game == false && Inning < 4))
                {
                    bat1L.SetActive(true);
                    bat1.SetActive(false);
                    bat1yowai.SetActive(false);
                    T1Text.text = string.Format("{0}�@���̂�", Team1Batter);
                }
                else
                {
                    bat1L.SetActive(true);
                    bat1.SetActive(false);
                    bat1yowai.SetActive(false);
                    T1Text.text = string.Format("{0}�@���܂�", Team1Batter);
                }
            }

        }
        else if (Team1 == 1)
        {
            AttackText.text = string.Format("�G�g���[��BC�F{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@�Ȃ䂽");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�ɂ������@��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@���Ƃ�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@���肽", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�킾�@��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}�@���킳��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}�@�ɂ������@��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�Ȃ䂽", Team1Batter);
            }
        }
        else if (Team1 == 2)
        {
            AttackText.text = string.Format("�S�����[�Y�F{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@�������傤P");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤CF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤RF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤SS", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤LF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤3B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤1B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤C", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤2B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤P", Team1Batter);
            }

        }
        else if (Team1 == 3)
        {
            AttackText.text = string.Format("{1}�F{0}", AtkPt,Team3.batter0);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@{0}",Team3.batter9);
            }
            
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter,Team3.batter1);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}" ,Team1Batter, Team3.batter2);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter3);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter4);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter5);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter6);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter7);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter8);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter9);
            }
        }
        else if (Team1 == 4)
        {
            AttackText.text = string.Format("{1}�F{0}", AtkPt,Team3.batter10);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@{0}", Team3.batter19);
            }

            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter11);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter12);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter13);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter14);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter15);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter16);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter17);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter18);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter19);
            }
        }
        else
        {
            AttackText.text = string.Format("��U�`�[���F{0}", AtkPt);
        }
        if (Team2 == 0)
        {
            DeffenceText.text = string.Format("�G�g���[���I���F{0}", DefPt);
            if (Inning2 == 0)
            {
                if ((game == true && Inning < 7) || (game == false && Inning < 4)) 
                {
                    T2Text.text = string.Format("P�@���̂�");
                }
                else
                {
                    T2Text.text = string.Format("P�@���܂�");
                }
                
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
               
                if ((game == true && 6 < Inning) || (game == false && 3 < Inning))
                {
                    bat2L.SetActive(false);
                    bat2.SetActive(true);
                    bat2yowai.SetActive(false);
                    T2Text.text = string.Format("{0}�@��܂���", Team2Batter);
                }
                else
                {
                    bat2L.SetActive(false);
                    bat2.SetActive(false);
                    bat2yowai.SetActive(true);
                    T2Text.text = string.Format("{0}�@�ق񂳂�", Team2Batter);
                }
                    
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�ӂ�����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@��܂�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@������", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�Ȃ���", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�����΂�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�킾�@��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
                T2Text.text = string.Format("{0}�@�킾�@��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                
                if ((game == true && Inning < 7) || (game == false && Inning < 4))
                {
                    bat2L.SetActive(true);
                    bat2.SetActive(false);
                    bat2yowai.SetActive(false);
                    T2Text.text = string.Format("{0}�@���̂�", Team2Batter);
                }
                else
                {
                    bat2L.SetActive(true);
                    bat2.SetActive(false);
                    bat2yowai.SetActive(false);
                    T2Text.text = string.Format("{0}�@���܂�", Team2Batter);
                }
            }
        }
        else if (Team2 == 1)
        {
            DeffenceText.text = string.Format("�G�g���[��BC�F{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P�@�Ȃ䂽");
                

            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@������", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�ɂ������@��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@���Ƃ�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@���肽", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�킾�@��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
                T2Text.text = string.Format("{0}�@���킳��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@������", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
                T2Text.text = string.Format("{0}�@�ɂ������@��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�Ȃ䂽", Team2Batter);
            }
        }
        else if (Team2 == 2)
        {
            DeffenceText.text = string.Format("�S�����[�Y�F{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P�@�������傤P");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤CF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
                T2Text.text = string.Format("{0}�@�������傤RF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤SS", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤LF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤3B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤1B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤C", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤2B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@�������傤P", Team2Batter);
            }
        }
        else if (Team2 == 3)
        {
            DeffenceText.text = string.Format("{1}�F{0}", DefPt,Team3.batter0);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P�@{0}",Team3.batter9);
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter,Team3.batter1);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter2);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter3);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter4);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter5);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter6);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter7);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter8);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter9);
            }
        }
        else if (Team2 == 4)
        {
            DeffenceText.text = string.Format("{1}�F{0}", DefPt,Team3.batter10);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P�@{0}", Team3.batter19);
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter11);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter12);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter13);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter14);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter15);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter16);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter17);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter18);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}�@{1}", Team2Batter, Team3.batter19);
            }
        }
        else
        {
            DeffenceText.text = string.Format("��U�`�[���F{0}", DefPt);
            bat2L.SetActive(false);
            bat2.SetActive(true);
        }
        #endregion
        #region//�����i�[
        if (Inning2 == 0)
        {
            if (Runner == 0)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("�����i�[�Ȃ�");
            }
            else if (Runner == 1)
            {
                Runner1.SetActive(true);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("�����i�[�P��");
            }
            else if (Runner == 2)
            {
                Runner1.SetActive(true);
                Runner2.SetActive(true);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("�����i�[�P,�Q��");
            }
            else if (Runner == 3)
            {
                Runner1.SetActive(true);
                Runner2.SetActive(true);
                Runner3.SetActive(true);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("�����i�[����");
            }
        }
        else if (Inning2 == 1)
        {
            if (Runner == 0)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("�����i�[�Ȃ�");
            }
            else if (Runner == 1)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(true);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("�����i�[�P��");
            }
            else if (Runner == 2)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(true);
                Runner5.SetActive(true);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("�����i�[�P,�Q��");
            }
            else if (Runner == 3)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(true);
                Runner5.SetActive(true);
                Runner6.SetActive(true);
                RunnerText.text = string.Format("�����i�[����");
            }
        }
        #endregion

        StrikeText.text = string.Format("S�F{0}", Strike);//�X�g���C�N�J�E���g
        OutText.text = string.Format("O�F{0}", Out);//�A�E�g�J�E���g

        #region//�����I������A�^�C�u���[�N����
        //�^�C�u���[�N
        if (game == false)
        {
            if (4 <= Inning && change == true)//���d�l
            {
                Runner = 2;
            }
        }
        else if (game == true)
        {
            if (10 <= Inning && change == true)
            {
                Runner = 2;
            }
        }

        //�`�F���W�������O��
        if (change == false && Wait == false)
        {
            CText.gameObject.SetActive(false);
        }
        //�����I������
        if (gameset == true)
        {
            sec2++;
        }
        if (game == false) {
            if (6 <= Inning)//���d�l
            {
                gameset = true;
                ChangeText.text = string.Format("�����I��\n" +
                    "Space�L�[�܂��͍��}�E�X�Ń^�C�g���ɖ߂�");
                CText.gameObject.SetActive(true);
                InningText.text = string.Format("�����I��");

                StrikeText.text = string.Format("��������");
                OutText.text = string.Format("");
                BGM4.gameObject.SetActive(true);
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

            }
            else if ((3 <= Inning && Inning2 == 1 && (AtkPt < DefPt)) || (AtkPt - DefPt <= -7))
            {
                gameset = true;
                ChangeText.text = string.Format("�����I��\n" +
                    "Space�L�[�܂��͍��}�E�X�Ń^�C�g���ɖ߂�");
                CText.gameObject.SetActive(true);
                InningText.text = string.Format("�����I��");
                
                StrikeText.text = string.Format("2�o�̏���");
                OutText.text = string.Format("");
                if (Ball.homerun == true)
                {
                    music5 = true;
                    BGM5.gameObject.SetActive(true);
                }
                else if(music5==false)
                {
                    BGM4.gameObject.SetActive(true);
                }
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

                Lose = true;
            }
            else if ((4 <= Inning && Inning2 == 0&&change==true && (AtkPt > DefPt))||(Inning2==0&&change==true&& AtkPt - DefPt >= 7) ||AtkPt - DefPt >= 10)
            {
                gameset = true;
                ChangeText.text = string.Format("�����I��\n" +
                    "Space�L�[�܂��͍��}�E�X�Ń^�C�g���ɖ߂�");
                CText.gameObject.SetActive(true);

                InningText.text = string.Format("�����I��");

                StrikeText.text = string.Format("1�o�̏���");
                OutText.text = string.Format("");
                BGM4.gameObject.SetActive(true);
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

                Win = true;
            }
        }
        else if (game == true)
        {
            if ((9 <= Inning && Inning2 == 1 &&change==true&& (AtkPt < DefPt) || (AtkPt - DefPt <= -10))||(9 <= Inning&& Inning2 == 1 && (AtkPt < DefPt)))
            {
                gameset = true;
                ChangeText.text = string.Format("�����I��\n" +
                    "Space�L�[�܂��͍��}�E�X�Ń^�C�g���ɖ߂�");
                CText.gameObject.SetActive(true);
                InningText.text = string.Format("�����I��");
                StrikeText.text = string.Format("2�o�̏���");
                OutText.text = string.Format("");

                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);
                if (Ball.homerun == true)
                {
                    music5 = true;
                    BGM5.gameObject.SetActive(true);
                }
                else if (music5 == false)
                {
                    BGM4.gameObject.SetActive(true);
                }
                Lose = true;
            }
            else if ((10 <= Inning && change == true && Inning2 == 0 && (AtkPt > DefPt)) || (Inning2 == 0 && change == true && AtkPt - DefPt >= 10))
            {
                gameset = true;
                ChangeText.text = string.Format("�����I��\n" +
                    "Space�L�[�܂��͍��}�E�X�Ń^�C�g���ɖ߂�");
                CText.gameObject.SetActive(true);


                StrikeText.text = string.Format("1�o�̏���");

                OutText.text = string.Format("");

                BGM4.gameObject.SetActive(true);
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

                Win = true;
            }
        }
        if (gameset == true && 300 < sec2 && (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)))//�^�C�g���ɖ߂�
        {
            SceneManager.LoadScene("Title");
        }
        //�������ԏ���(�g���Ă��Ȃ�)
        if (gameset == false)
        {
            sec++;
        }

        if (1000 <= sec)
        {
            min++;
            sec = 0;
        }
        if (60 <= min)
        {
            hour++;
            min = 0;
        }

        #endregion
        if (Inning2 == 0) 
        {
            ScoreText.text = string.Format("{0}��\\n{1}�@-�@{2}", Inning,AtkPt, DefPt);//�o�b�N�X�N���[���X�R�A
        }
        else if (Inning2 == 1)
        {
            ScoreText.text = string.Format("{0}��\n{1}�@-�@{2}", Inning, AtkPt, DefPt);//�o�b�N�X�N���[���X�R�A
        }
        if (Inning2 == 0&&change==true&&Wait==false)//�U���㏈��
        {
            Def1.gameObject.SetActive(true);
            Def2.gameObject.SetActive(false);
        }
        else if (Inning2 == 1 && change == true && Wait == false)//�U���㏈��
        {
            Def1.gameObject.SetActive(false);
            Def2.gameObject.SetActive(true);
        }
        if (Ball.strike == true && ballcontroll.shootSwitch == true && Ball.pitch == false && (Strike == 1 || Strike == 2) && gameset == false)//�X�g���C�N����
        {
            ChangeText.text = string.Format("�X�g���C�N");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.strike == true && ballcontroll.shootSwitch == true && Strike == 0 && change == false && gameset == false)//�O�U����
        {
            ChangeText.text = string.Format("�X�g���C�N�@�o�b�^�[�A�E�g");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.foul == true && ballcontroll.shootSwitch == true && gameset == false)//�t�@�[������
        {
            ChangeText.text = string.Format("�t�@�[��");
            CText.gameObject.SetActive(true);
        }

        else if (Ball.out1 == true && ballcontroll.shootSwitch == true && change == false && gameset == false)//�A�E�g����
        {
            ChangeText.text = string.Format("�A�E�g");
            CText.gameObject.SetActive(true);
            
        }
        //�`�F���W����
        else if (Ball.out1 == true && ballcontroll.shootSwitch == true && change == true && gameset == false)
        {
            ChangeText.text = string.Format("�U����");
            CText.gameObject.SetActive(true);
        }
        //�q�b�g����
        else if (Ball.hit == true && ballcontroll.shootSwitch == true && gameset == false)
        {
            ChangeText.text = string.Format("�q�b�g");
            CText.gameObject.SetActive(true);
        }
        //�z�[����������
        else if (Ball.homerun == true && ballcontroll.shootSwitch == true && gameset == false)
        {
            ChangeText.text = string.Format("�z�[������");
            CText.gameObject.SetActive(true);
        }
        //��������
        if (Ball.pitch==true)
        {
            Ball.strike = false;
            Ball.foul = false;
            Ball.out1 = false;
            Ball.hit = false;
            Ball.homerun = false;
            CText.gameObject.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        //�X�g���C�N�A�O�U����
        if (2 < Strike)
        {
            Strike = 0;
            Out++;
            if (Inning2 == 0)
            {
                Team1Batter++;
            }
            else if (Inning2 == 1)
            {
                Team2Batter++;
            }
        }
        //�`�F���W����
        if (2 < Out)
        {
            
            Out = 0;
            Runner = 0;
            Inning2++;
            Ball.hitBomb = false;
            change = true;
            Bakugeki.SetActive(true);
        }
        //�U���㏈��(������\)
        if (1 < Inning2)
        {
            Inning2 = 0;
            Inning++;
        }
        //�ŏ�����
        if (9 < Team1Batter)
        {
            Team1Batter = 1;
        }
        if (9 < Team2Batter)
        {
            Team2Batter = 1;
        }
    }
}
