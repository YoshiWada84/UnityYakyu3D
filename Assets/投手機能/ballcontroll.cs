using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroll : MonoBehaviour
{
    private float timer = 0.0f;
    private float timeLimit = 0.4f;
    public static bool shootSwitch;

    // Use this for initialization
    void Start()
    {
        shootSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootSwitch)
        {
            timer += Time.deltaTime;
        }

        if ((timer > timeLimit) & shootSwitch)
        {
            float z = 2; // force strength;
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 0, -z);

            timer = 0.0f;
            shootSwitch = false;
        }

    }


}
