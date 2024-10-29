using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTextes : MonoBehaviour
{
    public GameObject bat1;//�o�b�g
    public GameObject bat2;//�o�b�g
    public GameObject Bakugeki;//����
    public ballcontroll Ball;//�{�[��
    public GameObject Runner1;//�����i�[
    public GameObject Runner2;//�����i�[
    public GameObject Runner3;//�����i�[

    public GameObject Ground1;//�O���E���h1
    public GameObject Ground2;//�O���E���h2

    //BGM
    public GameObject BGM1;
    public GameObject BGM2;
    public GameObject BGM3;
    public GameObject BGM4;


    public Text InningText;     //��
    public Text AttackText;     //��U�`�[���̓��_
    public Text DeffenceText;   //��U�`�[���̓��_
    public Text RunnerText;     //�����i�[
    public Text StrikeText;     //�X�g���C�N�J�E���g
    public Text OutText;        //�A�E�g�J�E���g
    public Text ScoreText;        //�X�R�A�e�L�X�g
    public Text T1Text;        //�I��1�e�L�X�g
    public Text T2Text;        //�I��2�e�L�X�g

    public int hour = 0;       //����
    public int min = 0;         //��
    public int sec = 0;         //�b


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

        BGM1.gameObject.SetActive(true);
        BGM2.gameObject.SetActive(false);
        BGM3.gameObject.SetActive(false);
        BGM4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Wait == true)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                Team1 = 0;
                Team2 = 1;
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                Team1 = 0;
                Team2 = 2;
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                Team1 = 1;
                Team2 = 0;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                

            }
            else if (Input.GetKey(KeyCode.Alpha4))
            {
                Team1 = 1;
                Team2 = 2;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                

            }
            else if (Input.GetKey(KeyCode.Alpha5))
            {
                Team1 = 2;
                Team2 = 0;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                
            }
            else if (Input.GetKey(KeyCode.Alpha6))
            {
                Team1 = 2;
                Team2 = 1;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                
            }

        }
        if (Wait == true&&Input.GetKey(KeyCode.Return))
        {
            Wait = false;
            change = true;
            hour = 0;
            min = 0;
            sec = 0;
            Ball.timer = 0;
            BGM1.gameObject.SetActive(false);
        }
        #region//�`�[��
        if (Inning2 == 0&&Wait==false&&gameset==false)
        {
            bat1.gameObject.SetActive(true);
            bat2.gameObject.SetActive(false);
            InningText.text = string.Format("{0}��\", Inning);
            BGM2.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM3.gameObject.SetActive(false);
            BGM4.gameObject.SetActive(false);

        }
        
        if (Inning2 == 1&&Wait==false && gameset == false)
        {
            bat1.gameObject.SetActive(false);
            bat2.gameObject.SetActive(true);
            InningText.text = string.Format("{0}��", Inning);
            BGM3.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM2.gameObject.SetActive(false);
            BGM4.gameObject.SetActive(false);
            if (Team1 == 0)
            {
                T1Text.text = string.Format("P�@����");
            }
            else if (Team1 == 1)
            {
                T1Text.text = string.Format("P�@����");

            }
            else if (Team1 == 2)
            {
                T1Text.text = string.Format("P�@����ނ�");

            }
            else
            {
                T1Text.text = string.Format("P�@�I�薼");
            }
        }
        if (Team1 == 0)
        {
            AttackText.text = string.Format("�������[���F{0}", AtkPt);

            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@�ނ�");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                T1Text.text = string.Format("{0}�@�Ȃ�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                T1Text.text = string.Format("{0}�@���", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                T1Text.text = string.Format("{0}�@�Ă�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                T1Text.text = string.Format("{0}�@�܂�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                T1Text.text = string.Format("{0}�@�ނ�", Team1Batter);
            }

        }
        else if (Team1 == 1)
        {
            AttackText.text = string.Format("�؂�[���F{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@�^�C���[");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                T1Text.text = string.Format("{0}�@������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                T1Text.text = string.Format("{0}�@������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                T1Text.text = string.Format("{0}�@�������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                T1Text.text = string.Format("{0}�@�o�[�T�[�N", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                T1Text.text = string.Format("{0}�@���A���h��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                T1Text.text = string.Format("{0}�@�Ƃ��", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                T1Text.text = string.Format("{0}�@��������", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                T1Text.text = string.Format("{0}�@���߂���", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                T1Text.text = string.Format("{0}�@�^�C���[", Team1Batter);
            }
        }
        else if (Team1 == 2)
        {
            AttackText.text = string.Format("�S�X�y���[�Y�F{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P�@�������傤P");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                T1Text.text = string.Format("{0}�@�������傤CF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                T1Text.text = string.Format("{0}�@�������傤RF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                T1Text.text = string.Format("{0}�@�������傤SS", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                T1Text.text = string.Format("{0}�@�������傤LF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                T1Text.text = string.Format("{0}�@�������傤3B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                T1Text.text = string.Format("{0}�@�������傤1B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                T1Text.text = string.Format("{0}�@�������傤C", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                T1Text.text = string.Format("{0}�@�������傤2B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                T1Text.text = string.Format("{0}�@�������傤P", Team1Batter);
            }

        }
        else
        {
            AttackText.text = string.Format("��U�`�[���F{0}", AtkPt);
        }
        if (Team2 == 0)
        {
            DeffenceText.text = string.Format("�������[���F{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P�@����");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                T2Text.text = string.Format("{0}�@�Ȃ�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                T2Text.text = string.Format("{0}�@���", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                T2Text.text = string.Format("{0}�@�Ă�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                T2Text.text = string.Format("{0}�@�܂�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
        }
        else if (Team2 == 1)
        {
            DeffenceText.text = string.Format("�؂�[���F{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P�@���͂�");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                T2Text.text = string.Format("{0}�@������", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                T2Text.text = string.Format("{0}�@������", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                T2Text.text = string.Format("{0}�@�������", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                T2Text.text = string.Format("{0}�@�o�[�T�[�N", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                T2Text.text = string.Format("{0}�@���A���h��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                T2Text.text = string.Format("{0}�@�Ƃ��", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                T2Text.text = string.Format("{0}�@��������", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                T2Text.text = string.Format("{0}�@���߂���", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                T2Text.text = string.Format("{0}�@���͂�", Team2Batter);
            }
        }
        else if (Team2 == 2)
        {
            DeffenceText.text = string.Format("�S�X�y���[�Y�F{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P�@�������傤P");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                T2Text.text = string.Format("{0}�@�������傤CF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                T2Text.text = string.Format("{0}�@�������傤RF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                T2Text.text = string.Format("{0}�@�������傤SS", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                T2Text.text = string.Format("{0}�@�������傤LF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                T2Text.text = string.Format("{0}�@�������傤3B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                T2Text.text = string.Format("{0}�@�������傤1B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                T2Text.text = string.Format("{0}�@�������傤C", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                T2Text.text = string.Format("{0}�@�������傤2B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                T2Text.text = string.Format("{0}�@�������傤P", Team2Batter);
            }
        }
        else
        {
            DeffenceText.text = string.Format("��U�`�[���F{0}", DefPt);
        }
        #endregion
        #region//�����i�[

        if (Runner == 0)
        {
            Runner1.SetActive(false);
            Runner2.SetActive(false);
            Runner3.SetActive(false);
            RunnerText.text = string.Format("�����i�[�Ȃ�");
        }
        else if (Runner == 1)
        {
            Runner1.SetActive(true);
            Runner2.SetActive(false);
            Runner3.SetActive(false);
            RunnerText.text = string.Format("�����i�[�P��");
        }
        else if (Runner == 2)
        {
            Runner1.SetActive(true);
            Runner2.SetActive(true);
            Runner3.SetActive(false);
            RunnerText.text = string.Format("�����i�[�P,�Q��");
        }
        else if (Runner == 3)
        {
            Runner1.SetActive(true);
            Runner2.SetActive(true);
            Runner3.SetActive(true);
            RunnerText.text = string.Format("�����i�[����");
        }
        #endregion

        StrikeText.text = string.Format("S�F{0}", Strike);
        OutText.text = string.Format("O�F{0}", Out);

        #region//�����I������A�^�C�u���[�N����
        //�^�C�u���[�N
        if (4 <= Inning && change == true)
        {
            Runner = 2;
        }

        //�����I������
        if ((3 <= Inning && Inning2 == 1 && (AtkPt < DefPt)) /*|| AtkPt - DefPt <= -10*/)
        {
            InningText.text = string.Format("�����I��");
            if (Team2 == 0)
            {
                StrikeText.text = string.Format("�������[���̏���");
            }
            else if (Team2 == 1)
            {
                StrikeText.text = string.Format("�؂�[���̏���");
            }
            else if (Team2 == 2)
            {
                StrikeText.text = string.Format("�S�X�y���[�Y�̏���");
            }
            else
            {
                StrikeText.text = string.Format("��U�`�[���̏���");
            }
            OutText.text = string.Format("");
            gameset = true;
            BGM4.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM2.gameObject.SetActive(false);
            BGM3.gameObject.SetActive(false);

        }
        else if ((4 <= Inning && Inning2 == 0 && (AtkPt > DefPt) && change == true)/*||AtkPt-DefPt>=10*/)
        {
            InningText.text = string.Format("�����I��");
            if (Team1 == 0)
            {
                StrikeText.text = string.Format("�������[���̏���");
            }
            else if (Team1 == 1)
            {
                StrikeText.text = string.Format("�؂�[���̏���");
            }
            else if (Team1 == 2)
            {
                StrikeText.text = string.Format("�S�X�y���[�Y�̏���");
            }
            else
            {
                StrikeText.text = string.Format("��U�`�[���̏���");
            }

            OutText.text = string.Format("");
            gameset = true;
            BGM4.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM2.gameObject.SetActive(false);
            BGM3.gameObject.SetActive(false);

        }
        if (gameset == true &&Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Title");
        }
        /*else if (7 <= Inning && (AtkPt == DefPt))
        {
            InningText.text = string.Format("�����I��");
            StrikeText.text = string.Format("��������");
            OutText.text = string.Format("");
            gameset = true;
        }*/
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
        ScoreText.text = string.Format("{0}�@-�@{1}", AtkPt, DefPt);//�o�b�N�X�N���[���X�R�A
    }
    void FixedUpdate()
    {
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
        if (2 < Out)
        {
            Out = 0;
            Runner = 0;
            Inning2++;
            Ball.hitBomb = false;
            change = true;
            Bakugeki.SetActive(true);
        }
        if (1 < Inning2)
        {
            Inning2 = 0;
            Inning++;
        }
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
