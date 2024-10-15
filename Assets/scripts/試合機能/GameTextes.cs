using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextes : MonoBehaviour
{
    public GameObject bat1;//�o�b�g
    public GameObject bat2;//�o�b�g

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

    

    // Start is called before the first frame update
    void Start()
    {
        //�����֘A
        Inning = 1;
        Inning2 = 1;
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

        
}

// Update is called once per frame
void Update()
    {
        if (Inning2 == 0)
        {
            bat1.gameObject.SetActive(true);
            bat2.gameObject.SetActive(false);
            InningText.text = string.Format("{0}��\", Inning);
            if (Team2 == 0)
            {
                T2Text.text = string.Format("P�@�ނ�");
            }
            else if (Team2 == 1)
            {
                T2Text.text = string.Format("P�@����");
            }
            else
            {
                T2Text.text = string.Format("P�@�I�薼");
            }

        }
        if (Inning2 == 1)
        {
            bat1.gameObject.SetActive(false);
            bat2.gameObject.SetActive(true);
            InningText.text = string.Format("{0}��", Inning);
            if (Team1 == 0)
            {
                T1Text.text = string.Format("P�@����");
            }
            else if (Team1 == 1)
            {
                T1Text.text = string.Format("P�@����");

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
            if (Inning2 == 0&& Team1Batter == 1)
            {
                T1Text.text = string.Format("{0}�@����",Team1Batter);
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
                T1Text.text = string.Format("P�@����");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                T1Text.text = string.Format("{0}�@�悵", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                T1Text.text = string.Format("{0}�@�͂�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                T1Text.text = string.Format("{0}�@�ɂ��Ƃ�", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                T1Text.text = string.Format("{0}�@�ɂ�����", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                T1Text.text = string.Format("{0}�@����", Team1Batter);
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
                T2Text.text = string.Format("P�@����");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                T2Text.text = string.Format("{0}�@�悵", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                T2Text.text = string.Format("{0}�@�͂�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                T2Text.text = string.Format("{0}�@�ɂ��Ƃ�", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                T2Text.text = string.Format("{0}�@�ɂ�����", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                T2Text.text = string.Format("{0}�@����", Team2Batter);
            }
        }
        else
        {
            DeffenceText.text = string.Format("��U�`�[���F{0}", DefPt);
        }

        if (Runner == 0)
        {
            RunnerText.text = string.Format("�����i�[�Ȃ�");
        }
        else if (Runner == 1)
        {
            RunnerText.text = string.Format("�����i�[�P��");
        }
        else if (Runner == 2)
        {
            RunnerText.text = string.Format("�����i�[�P,�Q��");
        }
        else if (Runner == 3)
        {
            RunnerText.text = string.Format("�����i�[����");
        }

        StrikeText.text=    string.Format("S�F{0}",Strike);
        OutText.text=       string.Format("O�F{0}", Out);

        //�����I������
        if (3 <= Inning && Inning2 == 1 && (AtkPt < DefPt))
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
            else
            {
                StrikeText.text = string.Format("��U�`�[���̏���");
            }
            OutText.text = string.Format("");
            gameset = true;


        }
        else if (4 <= Inning && Inning2 == 0 && (AtkPt > DefPt) && change == true) 
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
            else
            {
                StrikeText.text = string.Format("��U�`�[���̏���");
            }
            
            OutText.text = string.Format("");
            gameset = true;
        }
        else if (7 <= Inning && (AtkPt == DefPt))
        {
            InningText.text = string.Format("�����I��");
            StrikeText.text = string.Format("��������");
            OutText.text = string.Format("");
            gameset = true;
        }
        if (gameset==false) 
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

        
        ScoreText.text = string.Format("{0}�@-�@{1}",AtkPt,DefPt);//�o�b�N�X�N���[���X�R�A
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
            change = true;
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
