using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public GameTextes gamas;//試合関連スクリプト
    public GameObject batbat;
    //public GameObject ball;
    [SerializeField, Tooltip("ターゲットオブジェクト")]
    private GameObject TargetObject;

    [SerializeField, Tooltip("回転軸")]
    private Vector3 RotateAxis = Vector3.up;

    [SerializeField, Tooltip("速度係数")]
    private float SpeedFactor = 0.1f;
    //public float swingATP = 3.0f;//スイングアビリティ


    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {


        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("通常スイングが選択されました。");

            if (TargetObject == null) return;


            //バッターを中心に回転する
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

            //バッターを中心に回転する
            this.transform.RotateAround(
                TargetObject.transform.position,
                RotateAxis,
                360.0f / (1.0f / SpeedFactor) * Time.deltaTime
                );

            Debug.Log("強スイングが選択されました。");

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
