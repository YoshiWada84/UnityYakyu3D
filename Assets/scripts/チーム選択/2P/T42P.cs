using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T42P : MonoBehaviour
{
    public AudioSource sound01;
    public GameTextes gamas;
    // Start is called before the first frame update
    public GameObject team1;
    public GameObject team2;
    public GameObject team3;
    public GameObject team4;
    private bool team = false;

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        sound01 = GetComponent<AudioSource>();
    }
    public void OnClickStartButton()
    {
        team1.gameObject.SetActive(false);
        team2.gameObject.SetActive(false);
        team3.gameObject.SetActive(false);
        team4.gameObject.SetActive(false);
        sound01.Stop();
        sound01.PlayOneShot(sound01.clip);
        team = true;
        gamas.Team2 = 3;
    }




}
