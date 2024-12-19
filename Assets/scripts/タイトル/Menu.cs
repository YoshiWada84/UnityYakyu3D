using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用
using Unity.VisualScripting;

public class Menu : MonoBehaviour
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

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        sound01 = GetComponent<AudioSource>();
        // ボタンコンポーネントの取得
        BT1 = GameObject.Find("/Canvas/1P").GetComponent<Button>();
        BT2 = GameObject.Find("/Canvas/2P").GetComponent<Button>();
        BT3 = GameObject.Find("/Canvas/タイムベース").GetComponent<Button>();
        BT4 = GameObject.Find("/Canvas/クレジット").GetComponent<Button>();
        BT5 = GameObject.Find("/Canvas/試合について").GetComponent<Button>();
        BT6 = GameObject.Find("/Canvas/操作").GetComponent<Button>();
        BT7 = GameObject.Find("/Canvas/収録").GetComponent<Button>();
        BT8 = GameObject.Find("/Canvas/END").GetComponent<Button>();
        BT9 = GameObject.Find("/Canvas/タイムベース1").GetComponent<Button>();

        // 最初に選択状態にしたいボタンの設定
        BT1.Select();
    }
    void FixedUpdate()
    {
        

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)))
        {
            sound01.Stop();
            sound01.PlayOneShot(sound01.clip);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            sound01.Stop();
            sound01.PlayOneShot(sound01.clip);
        }
    }
}