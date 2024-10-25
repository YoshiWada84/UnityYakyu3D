using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    public GameTextes gamas;//試合関連スクリプト
    public GameObject batbat;
    //public GameObject ball;
    private int r = 2; // Rotation Speed
    private int r_sum = 0;
    private int r_max = 260;


    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && r_sum < r_max)
        {
            Debug.Log("通常スイングが選択されました。");

            //if (TargetObject == null) return;

            transform.Rotate(0, -r, 0);
            r_sum += r;
        }
        else if (!Input.GetKey(KeyCode.Space) && r_sum != 0)
        {
            transform.Rotate(0, r, 0);
            r_sum -= r;
        }


        // Debug.Log("強スイングが選択されました。");


    }

    private void FixedUpdate()
    {


    }

}
