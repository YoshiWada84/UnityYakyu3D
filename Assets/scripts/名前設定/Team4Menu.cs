using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用
using Unity.VisualScripting;

public class Team4Menu : MonoBehaviour
{
    
    Button BT1;

    void Start()
    {
        
        // ボタンコンポーネントの取得
        BT1 = GameObject.Find("/Canvas/タイトル").GetComponent<Button>();

        // 最初に選択状態にしたいボタンの設定
        BT1.Select();
    }
    void FixedUpdate()
    {
        
    }
}