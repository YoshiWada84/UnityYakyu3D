using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatCollisionCPU : MonoBehaviour
{
    //private float bounce = 10f;

    public batCPU bat;
    public GameObject batbat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Ball")
        {
            bat.hit = true;
            
        }
    }
}
