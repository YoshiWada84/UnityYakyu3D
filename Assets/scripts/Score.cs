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
    private int Win1; //������
    private int Lose1; //�s�퐔
    private string key1 = "Win1"; //�n�C�X�R�A�̕ۑ���L�[1
    private string key2 = "Lose1"; //�n�C�X�R�A�̕ۑ���L�[2
    private bool unlit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Win1 = PlayerPrefs.GetInt(key1, 0);
        Lose1 = PlayerPrefs.GetInt(key2, 0);
        
        //�ۑ����Ă������n�C�X�R�A���L�[�ŌĂяo���擾���ۑ�����Ă��Ȃ����0�ɂȂ�
        highScoreText.text = "����: " + Win1.ToString()+ "\n����: " + Lose1.ToString();
        //�n�C�X�R�A��\��
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)&& Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.E))
        {
            PlayerPrefs.DeleteAll();
            Win1 = 0;
            Lose1 = 0;

            //�ۑ����Ă������n�C�X�R�A���L�[�ŌĂяo���擾���ۑ�����Ă��Ȃ����0�ɂȂ�
            highScoreText.text = "����: " + Win1.ToString() + "\n����: " + Lose1.ToString();
            //�n�C�X�R�A��\��
        }
        if (gamas.gameset == false)
        {
            unlit = true;
        }
        
        
        if (gamas.Win==true&&unlit==true)
        {
            Win1++;
            //�n�C�X�R�A�X�V

            PlayerPrefs.SetInt(key1, Win1);
            PlayerPrefs.SetInt(key2, Lose1);

            //�n�C�X�R�A��ۑ�

            highScoreText.text = "����: " + Win1.ToString() + "\n����: " + Lose1.ToString();
            //�n�C�X�R�A��\��
            unlit = false;
        }
        else if (gamas.Lose == true && unlit == true)
        {
            Lose1++;
            //�n�C�X�R�A�X�V

            PlayerPrefs.SetInt(key1, Win1);
            PlayerPrefs.SetInt(key2, Lose1);

            //�n�C�X�R�A��ۑ�

            highScoreText.text = "����: " + Win1.ToString() + "\n����: " + Lose1.ToString();
            //�n�C�X�R�A��\��
            unlit = false;
        }
        
    }
}
