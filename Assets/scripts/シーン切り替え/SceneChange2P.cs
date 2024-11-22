using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneChange2P : MonoBehaviour
{
    public AudioClip audio1;
    public AudioSource audioSource; //オーディオソース    
    public GameObject mask;
    public bool a=false;
    public void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>(); //オーディオソース取得
    }
    public void OnClickStartButton()
    {
        if (a == false)
        {
            audioSource.PlayOneShot(audio1);
            a = true;
            mask = GameObject.Find("RawImage");

            //画面全体に広げる
            mask.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);

            //透明度を最大にする
            Color color_before = mask.GetComponent<RawImage>().color;
            color_before.a = 0.0f;
            Color color_after = color_before;
            mask.GetComponent<RawImage>().color = color_after;

            //非活性にし画面を操作できるようにする
            mask.GetComponent<RawImage>().enabled = false;

            //画面遷移
            transition();
        }
    }
    void transition()
    {
        //フェードアウト処理を呼ぶ
        Call_Fade();
        //シーン切り替え
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

    //フェードアウト処理
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
