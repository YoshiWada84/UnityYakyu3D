using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// InputField���g����悤�ɂ���
using UnityEngine.UI;

public class NameSetA6 : MonoBehaviour
{
    public EnterName Name;

    // inputfield���i�[����ϐ�
    InputField inputField1;

    

    // Use this for initialization
    void Start()
    {

        // InputField�R���|�[�l���g���i�[
        inputField1 = GetComponent<InputField>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    // InputField�ɓ��͂��ꂽ���e���e�L�X�g�ɕ\��
    public void DisplayText()
    {
        
        Name.batter17 = inputField1.text; 
    }


}