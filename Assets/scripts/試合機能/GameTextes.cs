using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextes : MonoBehaviour
{
    public Text InningText;     //��
    public Text AttackText;     //��U�`�[���̓��_
    public Text DeffenceText;   //��U�`�[���̓��_
    public Text RunnerText;     //�����i�[
    public Text StrikeText;     //�X�g���C�N�J�E���g
    public Text OutText;        //�A�E�g�J�E���g

    public int Inning;      //��
    public int Inning2;      //�\��
    public int Team1;      //�`�[����U
    public int Team2;      //�`�[����U

    public int AtkPt;       //��U�`�[���̓��_��
    public int DefPt;       //��U�`�[���̓��_��
    public int Runner;      //�����i�[
    public int Strike;      //�X�g���C�N��
    public int Out;         //�A�E�g�̐�
    public bool gameset;         //�����I�����ۂ�

    // Start is called before the first frame update
    void Start()
    {
        Inning = 1;
        Inning2 = 0;
        Team1 = 2;
        Team2 = 2;
        AtkPt = 0;
        DefPt = 0;
        Runner = 0;
        Strike = 0;
        Out = 0;
        gameset = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Inning2 == 0)
        {
            InningText.text = string.Format("{0}��\", Inning);
        }
        if (Inning2 == 1)
        {
            InningText.text = string.Format("{0}��", Inning);
        }
        if (Team1 == 0)
        {
            AttackText.text = string.Format("�������[���F{0}", AtkPt);
        }
        else if (Team1 == 1)
        {
            AttackText.text = string.Format("�؂�[���F{0}", AtkPt);
        }
        else
        {
            AttackText.text = string.Format("��U�`�[���F{0}", AtkPt);
        }
        if (Team2 == 0)
        {
            DeffenceText.text = string.Format("�������[���F{0}", DefPt);
        }
        else if (Team1 == 1)
        {
            DeffenceText.text = string.Format("�؂�[���F{0}", DefPt);
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
            StrikeText.text = string.Format("��U�`�[���̏���");
            OutText.text = string.Format("");
            gameset = true;

           
}
        else if (4 <= Inning && (AtkPt > DefPt))
        {
            InningText.text = string.Format("�����I��");
            StrikeText.text = string.Format("��U�`�[���̏���");
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
    }
    void FixedUpdate()
    {
        if (2 < Strike)
        {
            Strike = 0;
            Out++;
        }
        if (2 < Out)
        {
            Out = 0;
            Runner = 0;
            Inning2++;
        }
        if (1 < Inning2)
        {
            Inning2 = 0;
            Inning++;
        }
        
    }
}
