using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public GameTextes gamas;//�����֘A�X�N���v�g
    public GameObject batbat;
    //public GameObject ball;
    [SerializeField, Tooltip("�^�[�Q�b�g�I�u�W�F�N�g")]
    private GameObject TargetObject;

    [SerializeField, Tooltip("��]��")]
    private Vector3 RotateAxis = Vector3.up;

    [SerializeField, Tooltip("���x�W��")]
    private float SpeedFactor = 0.1f;
    //public float swingATP = 3.0f;//�X�C���O�A�r���e�B


    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("�ʏ�X�C���O���I������܂����B");

            if (TargetObject == null) return;


            //�o�b�^�[�𒆐S�ɉ�]����
            this.transform.RotateAround(
                TargetObject.transform.position,
                RotateAxis,
                360.0f / (1.0f / SpeedFactor) * Time.deltaTime
                );

        }
        else if (!Input.GetKey(KeyCode.Space))
        {
            if ((-30 > TargetObject.transform.rotation.y) && (TargetObject.transform.rotation.y > -160))
            {
                TargetObject.transform.Rotate(0, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (TargetObject == null) return;

            //�o�b�^�[�𒆐S�ɉ�]����
            this.transform.RotateAround(
                TargetObject.transform.position,
                RotateAxis,
                360.0f / (1.0f / SpeedFactor) * Time.deltaTime
                );

            Debug.Log("���X�C���O���I������܂����B");

        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("The D button is being held down.");
        }
    }

    private void FixedUpdate()
    {


    }

}
