using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public GameTextes gamas;//�����֘A�X�N���v�g
    public GameObject batbat;//�o�b�g
    //public GameObject ball;
    private int r = 10; // Rotation Speed
    //private int r = 1; // Rotation Speed�e�X�g�p
    private int r_sum = 0;
    private int r_max = 260;

    public GameObject batbatCC;//�F�ւ�

    public ballcontroll BC;
    //public GameObject Bomb;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {

        if ((Input.GetKey(KeyCode.Space)|| (Input.GetKey(KeyCode.A))) && r_sum < r_max)
        {
            Debug.Log("�ʏ�X�C���O���I������܂����B");

            //if (TargetObject == null) return;
            //�X�C���O
            transform.Rotate(0, -r, 0);
            r_sum += r;
        }
        else if ((!Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.A) && r_sum != 0))
        {

            //�X�C���O
            transform.Rotate(0, r, 0);
            r_sum -= r;
            batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKey(KeyCode.A) && BC.hitBomb == false)
        {
            //�����_���X�C���O
            batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }

    }

    private void FixedUpdate()
    {


    }

}
