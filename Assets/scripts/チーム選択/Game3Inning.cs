using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game3Inning : MonoBehaviour
{
    public AudioSource sound01;
    public GameTextes gamas;
    // Start is called before the first frame update
    public GameObject team1;
    

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        sound01 = GetComponent<AudioSource>();
    }
    public void OnClickStartButton()
    {
        team1.gameObject.SetActive(false);

        gamas.game = false;
        sound01.Stop();
        sound01.PlayOneShot(sound01.clip);
        
        
    }




}
