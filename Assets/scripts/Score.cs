using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text highScoreText; //ハイスコアを表示するText
    public GameTextes gamas;
    private int win1; //勝利数
    private int lose1; //敗戦数
    private string key1 = "Win1"; //ハイスコアの保存先キー1
    private string key2 = "Lose1"; //ハイスコアの保存先キー2
    private bool unlit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        win1 = PlayerPrefs.GetInt(key1, 0);
        lose1 = PlayerPrefs.GetInt(key2, 0);

        //保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
        highScoreText.text = "1P勝利数: " + win1.ToString() + "\n2P勝利数: " + lose1.ToString();
        //ハイスコアを表示
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            PlayerPrefs.DeleteAll();
            win1 = 0;
            lose1 = 0;

            //保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
            highScoreText.text = "1P勝利数: " + win1.ToString() + "\n2P勝利数: " + lose1.ToString();
            //ハイスコアを表示
        }
        if (gamas.gameset == false)
        {
            unlit = true;
        }
        
        
        if (gamas.Win==true&&unlit==true)
        {
            win1++;
            //ハイスコア更新

            PlayerPrefs.SetInt(key1, win1);
            PlayerPrefs.SetInt(key2, lose1);

            //ハイスコアを保存

            highScoreText.text = "勝ち: " + win1.ToString() + "\n負け: " + lose1.ToString();
            //ハイスコアを表示
            unlit = false;
        }
        else if (gamas.Lose == true && unlit == true)
        {
            lose1++;
            //ハイスコア更新

            PlayerPrefs.SetInt(key1, win1);
            PlayerPrefs.SetInt(key2, lose1);

            //ハイスコアを保存

            highScoreText.text = "勝ち: " + win1.ToString() + "\n負け: " + lose1.ToString();
            //ハイスコアを表示
            unlit = false;
        }
        
    }
}
