using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat1P : MonoBehaviour
{
    public GameTextes gamas;//�����֘A�X�N���v�g
    public GameObject batbat;

    //private int r = 10; // Rotation Speed
    private int r = 2; // Rotation Speed�e�X�g�p

    private int r_sum = 0;
    private int r_max = 260;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {


        if ((Input.GetKey(KeyCode.Space)|| Input.GetMouseButton(0)||Input.GetKey(KeyCode.A)) && r_sum < r_max)
        {
            Debug.Log("�ʏ�X�C���O���I������܂����B");

            transform.Rotate(0, -r, 0);
            r_sum += r;
        }
        else if ((!Input.GetKey(KeyCode.Space)&& !Input.GetMouseButton(0)&& !Input.GetKey(KeyCode.A)) && r_sum != 0)
        {
            transform.Rotate(0, r, 0);
            r_sum -= r;
        }
    }
    

    private void FixedUpdate()
    {


    }

}
