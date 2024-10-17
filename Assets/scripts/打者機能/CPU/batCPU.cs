using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batCPU : MonoBehaviour
{
    public GameTextes gamas;//試合関連スクリプト
    
        
    public ballcontroll ball;
    public GameObject batbat;
    public bool hit=false;
    //public GameObject ball;
    [SerializeField, Tooltip("ターゲットオブジェクト")]
    private GameObject TargetObject;

    [SerializeField, Tooltip("回転軸")]
    private Vector3 RotateAxis = Vector3.up;

    [SerializeField, Tooltip("速度係数")]
    private float SpeedFactor = -2f;
    //public float swingATP = 3.0f;//スイングアビリティ

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
            //Debug.Log("通常スイングが選択されました。");

            if (TargetObject == null) return;


            //バッターを中心に回転する
            this.transform.RotateAround(
                TargetObject.transform.position,
                RotateAxis,
                360.0f / (1.0f / SpeedFactor) * Time.deltaTime
                );

        }
        else if (hit == true && ( 120>ball.transform.position.z || 140 < ball.transform.position.z))
        {
            //Debug.Log("通常スイングが選択されました。");

            if (TargetObject == null) return;


            //バッターを中心に回転する
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
