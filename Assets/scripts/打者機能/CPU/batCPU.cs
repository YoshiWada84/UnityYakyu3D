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

    public int rand;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {

        rand = Random.Range(0, 12);
        

        if (hit == false&&ball.transform.position.z < rand)
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
        else if (hit == true && ( 120>ball.transform.position.z || 140 < ball.transform.position.z))
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
