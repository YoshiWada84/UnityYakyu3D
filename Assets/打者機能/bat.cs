using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{

    public GameObject batbat;
    private float bounce = 10f;
    [SerializeField, Tooltip("ターゲットオブジェクト")]
    private GameObject TargetObject;

    [SerializeField, Tooltip("回転軸")]
    private Vector3 RotateAxis = Vector3.up;

    [SerializeField, Tooltip("速度係数")]
    private float SpeedFactor = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
    
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("The Space button is being held down.");

            if (TargetObject == null) return;

            //バッターを中心に回転する
            this.transform.RotateAround(
                TargetObject.transform.position,
                RotateAxis,
                360.0f / (1.0f / SpeedFactor) * Time.deltaTime
                );

        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("The A button is being held down.");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("The D button is being held down.");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(-bounce, 0f, 0f, ForceMode.Impulse);
        if (collision.gameObject.tag == "Ball") 
        {
            batbat.gameObject.transform.Rotate(90, 45, -90);
        }
    }

}
