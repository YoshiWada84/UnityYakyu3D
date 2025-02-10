using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat1PP : MonoBehaviour
{
    public GameTextes1 gamas;//試合関連スクリプト
    public GameObject batbat;
    public GameObject batbatCC;//色替え
    public ballcontroll1 BC;

    private int r = 10; // Rotation Speed
    //private int r = 1; // Rotation Speedテスト用

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
            Debug.Log("通常スイングが選択されました。");

            transform.Rotate(0, -r, 0);
            r_sum += r;
            
        }
        else if ((!Input.GetKey(KeyCode.Space)&& !Input.GetMouseButton(0)&& !Input.GetKey(KeyCode.A)) && r_sum != 0)
        {
            transform.Rotate(0, r, 0);
            r_sum -= r;
            batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKey(KeyCode.A)&&BC.hitBomb==false)
        {
            batbatCC.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        
        
    }
    

    private void FixedUpdate()
    {


    }
    
}
