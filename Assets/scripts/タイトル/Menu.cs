using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UI�R���|�[�l���g�̎g�p
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
        //AudioSource�R���|�[�l���g���擾���A�ϐ��Ɋi�[
        sound01 = GetComponent<AudioSource>();
        // �{�^���R���|�[�l���g�̎擾
        BT1 = GameObject.Find("/Canvas/1P").GetComponent<Button>();
        BT2 = GameObject.Find("/Canvas/2P").GetComponent<Button>();
        BT3 = GameObject.Find("/Canvas/�^�C���x�[�X").GetComponent<Button>();
        BT4 = GameObject.Find("/Canvas/�N���W�b�g").GetComponent<Button>();
        BT5 = GameObject.Find("/Canvas/�����ɂ���").GetComponent<Button>();
        BT6 = GameObject.Find("/Canvas/����").GetComponent<Button>();
        BT7 = GameObject.Find("/Canvas/���^").GetComponent<Button>();
        BT8 = GameObject.Find("/Canvas/END").GetComponent<Button>();
        BT9 = GameObject.Find("/Canvas/�^�C���x�[�X1").GetComponent<Button>();

        // �ŏ��ɑI����Ԃɂ������{�^���̐ݒ�
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