using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用
using Unity.VisualScripting;

public class Team : MonoBehaviour
{
    public AudioSource sound01;
    Button BT1;
    Button BT2;
    Button BT3;
    Button BT4;
    Button BT5;
    Button BT6;
    Button BT7;
    Button BT8;
    Button BT9;
    Button BT10;
    Button BT11;
    Button BT12;
    Button BT13;

    public GameTextes gamas;

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        sound01 = GetComponent<AudioSource>();
        // ボタンコンポーネントの取得
        BT1 = GameObject.Find("/Canvas/TeamPlay/1P").GetComponent<Button>();
        BT2 = GameObject.Find("/Canvas/TeamPlay/1P1").GetComponent<Button>();
        BT3 = GameObject.Find("/Canvas/TeamPlay/1P2").GetComponent<Button>();
        BT4 = GameObject.Find("/Canvas/TeamPlay/1P3").GetComponent<Button>();
        BT5 = GameObject.Find("/Canvas/TeamPlay/2P").GetComponent<Button>();
        BT6 = GameObject.Find("/Canvas/TeamPlay/2P1").GetComponent<Button>();
        BT7 = GameObject.Find("/Canvas/TeamPlay/2P2").GetComponent<Button>();
        BT8 = GameObject.Find("/Canvas/TeamPlay/2P3").GetComponent<Button>();
        BT9 = GameObject.Find("/Canvas/TeamPlay/Play").GetComponent<Button>();
        BT10 = GameObject.Find("/Canvas/TeamPlay/1P4").GetComponent<Button>();
        BT11 = GameObject.Find("/Canvas/TeamPlay/2P4").GetComponent<Button>();
        BT12 = GameObject.Find("/Canvas/TeamPlay/3回").GetComponent<Button>();
        BT13 = GameObject.Find("/Canvas/TeamPlay/9回").GetComponent<Button>();

        // 最初に選択状態にしたいボタンの設定
        BT1.Select();
    }
    void Update()
    {

        if (gamas.Wait == true)
        {
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)))
            {
                sound01.Stop();
                sound01.PlayOneShot(sound01.clip);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                sound01.Stop();
                sound01.PlayOneShot(sound01.clip);
            }
        }
    }
}