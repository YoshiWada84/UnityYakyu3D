using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text highScoreText; //�n�C�X�R�A��\������Text
    public GameTextes gamas;
    private int win1; //������
    private int lose1; //�s�퐔
    private string key1 = "Win1"; //�n�C�X�R�A�̕ۑ���L�[1
    private string key2 = "Lose1"; //�n�C�X�R�A�̕ۑ���L�[2
    private bool unlit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        win1 = PlayerPrefs.GetInt(key1, 0);
        lose1 = PlayerPrefs.GetInt(key2, 0);

        //�ۑ����Ă������n�C�X�R�A���L�[�ŌĂяo���擾���ۑ�����Ă��Ȃ����0�ɂȂ�
        highScoreText.text = "1P������: " + win1.ToString() + "\n2P������: " + lose1.ToString();
        //�n�C�X�R�A��\��
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            PlayerPrefs.DeleteAll();
            win1 = 0;
            lose1 = 0;

            //�ۑ����Ă������n�C�X�R�A���L�[�ŌĂяo���擾���ۑ�����Ă��Ȃ����0�ɂȂ�
            highScoreText.text = "1P������: " + win1.ToString() + "\n2P������: " + lose1.ToString();
            //�n�C�X�R�A��\��
        }
        if (gamas.gameset == false)
        {
            unlit = true;
        }
        
        
        if (gamas.Win==true&&unlit==true)
        {
            win1++;
            //�n�C�X�R�A�X�V

            PlayerPrefs.SetInt(key1, win1);
            PlayerPrefs.SetInt(key2, lose1);

            //�n�C�X�R�A��ۑ�

            highScoreText.text = "����: " + win1.ToString() + "\n����: " + lose1.ToString();
            //�n�C�X�R�A��\��
            unlit = false;
        }
        else if (gamas.Lose == true && unlit == true)
        {
            lose1++;
            //�n�C�X�R�A�X�V

            PlayerPrefs.SetInt(key1, win1);
            PlayerPrefs.SetInt(key2, lose1);

            //�n�C�X�R�A��ۑ�

            highScoreText.text = "����: " + win1.ToString() + "\n����: " + lose1.ToString();
            //�n�C�X�R�A��\��
            unlit = false;
        }
        
    }
}
