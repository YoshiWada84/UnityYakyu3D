using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batmouse : MonoBehaviour
{
    public GameTextes gamas;//試合関連スクリプト
    public GameObject batbat;
    public ballcontroll ball;
    private int r = 10; // Rotation Speed
    //private int r = 1; // Rotation Speedテスト用

    private int r_sum = 0;
    private int r_max = 260;

    public GameObject batbatCC;//色替え
    //public float swingATP = 3.0f;//スイングアビリティ


    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {


        if ((Input.GetMouseButton(0)|| Input.GetMouseButton(1)) && r_sum < r_max)
        {
            Debug.Log("通常スイングが選択されました。");

            transform.Rotate(0, -r, 0);
            r_sum += r;
        }
        else if ((!Input.GetMouseButton(0) && (!Input.GetMouseButton(1)) && r_sum != 0))
        {
            transform.Rotate(0, r, 0);
            r_sum -= r;
            batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetMouseButton(1) && ball.hitBomb == false)
        {
            batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

            if (ball.hitter == true)
            {
                ball.hitBomb = true;

            }
        }

    }

    private void FixedUpdate()
    {


    }
    void OnCollisionEnter(Collision collision)
    {
        

    }
}
