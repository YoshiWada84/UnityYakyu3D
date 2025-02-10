using ExplosionSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batCPU1 : MonoBehaviour
{
    
    public GameTextes gamas;//試合関連スクリプト
    public ballcontroll ball;
    public GameObject batbat;
    public GameObject Bomb;
    public GameObject batbatCC;//色替え
    private int r = -10; // Rotation Speed
    //private int r = -1; // Rotation Speedテスト用

    private int r_sum = 0;
    private int r_max = -260;
    public bool hit=false;
    //public GameObject ball;
    [SerializeField, Tooltip("ターゲットオブジェクト")]
    private GameObject TargetObject;

    [SerializeField, Tooltip("回転軸")]
    private Vector3 RotateAxis = Vector3.up;

    [SerializeField, Tooltip("速度係数")]
    private float SpeedFactor = 2f;
    //public float swingATP = 3.0f;//スイングアビリティ
   
    public int rand;

    
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (ball.pitch2 == true)
        {
            rand = Random.Range(1, 9);
        }

        if ((ball.transform.position.z < rand) && r_sum > r_max)
        {
            if (TargetObject == null) return;

            transform.Rotate(0, -r, 0);
            r_sum += r;

        }
        else if (r_sum != 0)
        {
            //Debug.Log("通常スイングが選択されました。");
            transform.Rotate(0, r, 0);
            r_sum -= r;
            if (TargetObject == null) return;
            batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.blue;

        }


        if (gamas.game==false) {
            if (ball.hitBomb == false && ((gamas.Runner + 1 > gamas.AtkPt - gamas.DefPt && 3 <= gamas.Inning) || gamas.Out == 2) && -20 < r_sum)
            {
                batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
        else if (gamas.game == true)
        {
            if (ball.hitBomb == false && ((gamas.Runner + 1 > gamas.AtkPt - gamas.DefPt && 9 <= gamas.Inning) || gamas.Out == 2) && -20 < r_sum)
            {
                batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }

    }

    private void FixedUpdate()
    {


    }

}
