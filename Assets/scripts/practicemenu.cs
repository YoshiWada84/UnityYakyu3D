using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UI�R���|�[�l���g�̎g�p
using Unity.VisualScripting;

public class practicemenu : MonoBehaviour
{
    
    Button BT1;

    void Start()
    {
        
        // �{�^���R���|�[�l���g�̎擾
        BT1 = GameObject.Find("/Canvas/TeamPlay/Play").GetComponent<Button>();

        // �ŏ��ɑI����Ԃɂ������{�^���̐ݒ�
        BT1.Select();
    }
    void FixedUpdate()
    {
        
    }
}