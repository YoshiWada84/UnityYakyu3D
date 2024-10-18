using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatCollisionCPU : MonoBehaviour
{
    //private float bounce = 10f;
    public ballcontroll ball;
    public batCPU bat;
    public GameObject batbat;
    public GameTextes gamas;
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
        if (collision.gameObject.tag == "Ball"&&ball.hitBomb==false&&(gamas.Runner+1>gamas.AtkPt-gamas.DefPt||gamas.Out==2))
        {
            bat.hit = true;
            ball.hitBomb = true;
        }
        else if (collision.gameObject.tag == "Ball")
        {
            bat.hit = true;
            
        }
    }
}
