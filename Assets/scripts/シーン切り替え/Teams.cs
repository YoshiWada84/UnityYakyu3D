using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teams : MonoBehaviour
{
    public Teams1 teams;
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
        if (button == false && teams.button == false)
        {
            img1.gameObject.SetActive(true);
            button = true;
        }
        else if (button == true && teams.button == false)
        {
            img1.gameObject.SetActive(false);
            button = false;
        }
        else if (button == false && teams.button == true)
        {
            img1.gameObject.SetActive(true);
            teams.img1.gameObject.SetActive(false);

            teams.button = false;
            button = true;
        }

    }
}
