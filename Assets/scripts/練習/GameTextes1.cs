using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTextes1 : MonoBehaviour
{
    public GameObject bat1;//�o�b�g
    public GameObject bat1L;//�o�b�g��
    

    public GameObject Bakugeki;//����
    public ballcontroll1 Ball;//�{�[��
   
    
    public GameObject Ground1;//�O���E���h1
    

   

    public GameObject CText;//�`�F���W�e�L�X�g
    public GameObject CText2;//�`�F���W�e�L�X�g
    
    
    public Text StrikeText;     //�X�g���C�N�J�E���g
    
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
        

        CText.gameObject.SetActive(false);
        CText2.gameObject.SetActive(true);


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Ball.hitBomb = false;
            Bakugeki.gameObject.SetActive(true);
        }
        
        if (Wait == true)
        {
            
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Title");

            }
            

        }
        
        #region//�`�[��
        if (Inning2 == 0&&Wait==false&&gameset==false)
        {
            
            
        }
        
        if (Inning2 == 1&&Wait==false && gameset == false)
        {
            bat1.gameObject.SetActive(false);
            bat1L.gameObject.SetActive(false);
            
            
        }
        
        if (Team1 == 0)
        {
            
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@���炷");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@�΂�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@�ӂ��낤", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�Ƃ�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@����ǂ�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@���炷", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }

        }
        else if (Team1 == 1)
        {
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@�^�C���[");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@�������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�o�[�T�[�N", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@���A���h��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@�Ƃ��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@��������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@���߂���", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�^�C���[", Team1Batter);
            }
        }
        else if (Team1 == 2)
        {
           
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@�������傤P");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤CF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤RF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤SS", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤LF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤3B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}�@�������傤1B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤C", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤2B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@�������傤P", Team1Batter);
            }

        }
        else if (Team1 == 3)
        {
            
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@{0}",Team3.batter9);
            }
            
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter,Team3.batter1);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}" ,Team1Batter, Team3.batter2);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter3);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter4);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter5);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter6);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter7);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter8);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter9);
            }
        }
        else if (Team1 == 4)
        {
            
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@{0}", Team3.batter19);
            }

            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter11);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter12);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter13);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter14);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter15);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter16);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter17);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter18);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}�@{1}", Team1Batter, Team3.batter19);
            }
        }
        
        #endregion
        #region//�����i�[
        
        
        #endregion

        StrikeText.text = string.Format("S�F{0}", Strike);//�X�g���C�N�J�E���g
        

        

        //�`�F���W�������O��
        if (change == false && Wait == false)
        {
            CText.gameObject.SetActive(false);
        }
      
        if ( (Input.GetKey(KeyCode.Escape)))//�^�C�g���ɖ߂�
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

        if (Inning2 == 0) 
        {
            ScoreText.text = string.Format("1P�`�[���@{0}\n2P�`�[���@{1}", AtkPt, DefPt);//�o�b�N�X�N���[���X�R�A
        }
        else if (Inning2 == 1)
        {
            ScoreText.text = string.Format("1P�`�[���@{0}\n2P�`�[���@{1}", AtkPt, DefPt);//�o�b�N�X�N���[���X�R�A
        }     
        if (Ball.strike == true && ballcontroll1.shootSwitch == true && Ball.pitch == false && (Strike == 1 || Strike == 2) && gameset == false)//�X�g���C�N����
        {
            ChangeText.text = string.Format("�X�g���C�N");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.strike == true && ballcontroll1.shootSwitch == true && Strike == 0 && change == false && gameset == false)//�O�U����
        {
            ChangeText.text = string.Format("�X�g���C�N�@�o�b�^�[�A�E�g");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.foul == true && ballcontroll1.shootSwitch == true && gameset == false)//�t�@�[������
        {
            ChangeText.text = string.Format("�t�@�[��");
            CText.gameObject.SetActive(true);
        }

        else if (Ball.out1 == true && ballcontroll1.shootSwitch == true && change == false && gameset == false)//�A�E�g����
        {
            ChangeText.text = string.Format("�A�E�g");
            CText.gameObject.SetActive(true);
            
        }
        //�`�F���W����
        else if (Ball.out1 == true && ballcontroll1.shootSwitch == true && change == true && gameset == false)
        {
            ChangeText.text = string.Format("�U����");
            CText.gameObject.SetActive(true);
        }
        //�q�b�g����
        else if (Ball.hit == true && ballcontroll1.shootSwitch == true && gameset == false)
        {
            ChangeText.text = string.Format("�q�b�g");
            CText.gameObject.SetActive(true);
        }
        //�z�[����������
        else if (Ball.homerun == true && ballcontroll1.shootSwitch == true && gameset == false)
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
        if (0 < Inning2)
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
