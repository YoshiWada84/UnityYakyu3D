using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UI�R���|�[�l���g�̎g�p
using Unity.VisualScripting;

public class Team4Menu : MonoBehaviour
{
    
    Button BT1;

    void Start()
    {
        
        // �{�^���R���|�[�l���g�̎擾
        BT1 = GameObject.Find("/Canvas/�^�C�g��").GetComponent<Button>();

        // �ŏ��ɑI����Ԃɂ������{�^���̐ݒ�
        BT1.Select();
    }
    void FixedUpdate()
    {
        
    }
}