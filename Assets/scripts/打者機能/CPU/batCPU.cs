using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batCPU : MonoBehaviour
{
    public GameTextes gamas;//�����֘A�X�N���v�g
    
        
    public ballcontroll ball;
    public GameObject batbat;
    public bool hit=false;
    //public GameObject ball;
    [SerializeField, Tooltip("�^�[�Q�b�g�I�u�W�F�N�g")]
    private GameObject TargetObject;

    [SerializeField, Tooltip("��]��")]
    private Vector3 RotateAxis = Vector3.up;

    [SerializeField, Tooltip("���x�W��")]
    private float SpeedFactor = -2f;
    //public float swingATP = 3.0f;//�X�C���O�A�r���e�B


    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {


        if (hit == false&&ball.transform.position.z < 9)
        {
            //Debug.Log("�ʏ�X�C���O���I������܂����B");

            if (TargetObject == null) return;


            //�o�b�^�[�𒆐S�ɉ�]����
            this.transform.RotateAround(
                TargetObject.transform.position,
                RotateAxis,
                360.0f / (1.0f / SpeedFactor) * Time.deltaTime
                );

        }
       




    }

    private void FixedUpdate()
    {


    }

}
