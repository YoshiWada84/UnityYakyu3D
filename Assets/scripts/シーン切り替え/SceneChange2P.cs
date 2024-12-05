using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneChange2P : MonoBehaviour
{
    public AudioClip audio1;
    public AudioSource audioSource; //�I�[�f�B�I�\�[�X    
    public GameObject mask;
    public bool a=false;
    public void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>(); //�I�[�f�B�I�\�[�X�擾
    }
    public void OnClickStartButton()
    {
        if (a == false)
        {
            audioSource.PlayOneShot(audio1);
            a = true;
            mask = GameObject.Find("RawImage");

            //��ʑS�̂ɍL����
            mask.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);

            //�����x���ő�ɂ���
            Color color_before = mask.GetComponent<RawImage>().color;
            color_before.a = 0.0f;
            Color color_after = color_before;
            mask.GetComponent<RawImage>().color = color_after;

            //�񊈐��ɂ���ʂ𑀍�ł���悤�ɂ���
            mask.GetComponent<RawImage>().enabled = false;

            //��ʑJ��
            transition();
        }
    }
    void transition()
    {
        //�t�F�[�h�A�E�g�������Ă�
        Call_Fade();
        //�V�[���؂�ւ�
        Invoke("Scene", 1.0f);
    }
    void Scene()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void Call_Fade()
    {
        mask.GetComponent<RawImage>().enabled = true;
        StartCoroutine("Fade", mask);
    }

    //�t�F�[�h�A�E�g����
    IEnumerator Fade(GameObject mask)
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = mask.GetComponent<RawImage>().color;
            color.a += 0.01f;
            mask.GetComponent<RawImage>().color = color;


            if (i == 99)
            {
                yield break;
            }
            else
            {
                yield return null;
            }
        }
    }
}
