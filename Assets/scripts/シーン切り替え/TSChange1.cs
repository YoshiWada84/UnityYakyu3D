using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TSChange1 : MonoBehaviour
{
    public AudioClip audio1;
    private AudioSource audioSource; //オーディオソース    
    public GameObject mask;
    public int a = 0;

    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    
    // Start is called before the first frame update
    private void Start()
    {
        
        audioSource = this.gameObject.GetComponent<AudioSource>(); //オーディオソース取得
    }
    public void OnClickStartButton()
    {
        audioSource.PlayOneShot(audio1); //効果音を一回だけ鳴らす
        if (a == 0) 
        {
            a = 1;
            
            img1.gameObject.SetActive(false);
            img2.gameObject.SetActive(false);
            img3.gameObject.SetActive(false);
            img4.gameObject.SetActive(false);
            img5.gameObject.SetActive(false);
            Invoke("Onclick", 0.1f);
            
                                            
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
   
    
    // Update is called once per frame
    void FixedUpdate()
    {
        
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