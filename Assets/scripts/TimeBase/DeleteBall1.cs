using UnityEngine;
using System.Collections;

public class DeleteBall1 : MonoBehaviour
{
    public GameTimeBase gamas;
    public ballcontroll1 ball;
    private Rigidbody rig;
    public int time=0;
    // Use this for initialization
    void Start()
    {
        rig = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (3000 <= time||ball.strike==true || ball.foul == true || ball.out1 == true || ball.hit == true || ball.homerun == true)
        {
            time = 0;
            rig.velocity = Vector3.zero;
            rig.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 1, 20f);
            ballcontroll1.shootSwitch = true;
        }
        if (ball.pitch == false&& gamas.gameset == false && gamas.change == false && gamas.Wait == false)
        {
            time++;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground" & collision.gameObject.tag != "Bat"& collision.gameObject.tag != "town")
        {
            //Destroy(gameObject);
            rig.velocity = Vector3.zero;
            rig.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 1, 20f);
            ballcontroll1.shootSwitch = true;
        }
    }
}