using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teams : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;

    public SceneChange1P sceneChange1P;
    public SceneChange2P sceneChange2P;
    public GameObject img1;
    public AudioClip audio1;
    public AudioSource audioSource; //オーディオソース
                                     //
    public bool button=false;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneChange1P.a == true)
        {
            img1.gameObject.SetActive(false);
        }
        if (sceneChange2P.a == true)
        {
            img1.gameObject.SetActive(false);
        }
    }
    public void OnClickStartButton()
    {
        audioSource.PlayOneShot(audio1); //効果音を一回だけ鳴らす
        if (button == false )
        {
            img1.gameObject.SetActive(true);
            a1.SetActive(false);
            a2.SetActive(false);
            a3.SetActive(false);
            button = true;
            
        }
        else if (button == true)
        {
            img1.gameObject.SetActive(false);
            button = false;
            a1.SetActive(true);
            a2.SetActive(true);
            a3.SetActive(true);
        }
        


    }
}
