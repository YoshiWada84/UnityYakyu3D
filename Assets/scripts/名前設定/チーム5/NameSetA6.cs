using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// InputFieldを使えるようにする
using UnityEngine.UI;

public class NameSetA6 : MonoBehaviour
{
    public EnterName Name;

    // inputfieldを格納する変数
    InputField inputField1;

    

    // Use this for initialization
    void Start()
    {

        // InputFieldコンポーネントを格納
        inputField1 = GetComponent<InputField>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    // InputFieldに入力された内容をテキストに表示
    public void DisplayText()
    {
        
        Name.batter17 = inputField1.text; 
    }


}