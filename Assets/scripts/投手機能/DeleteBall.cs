using UnityEngine;
using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime;

public class DeleteBall : MonoBehaviour
{
    public GameTextes gamas;
    public ballcontroll ball;
    private Rigidbody rig;
    public int time=0;

    public AudioSource HitAudio;
    public AudioClip HitSE;
    // Use this for initialization
    void Start()
    {
        //HitAudio = gameObject.GetComponent<AudioSource>();
        rig = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(3000 <= time )
        {
            time = 0;
            HitAudio.Stop();
            HitAudio.PlayOneShot(HitSE);
            rig.velocity = Vector3.zero;
            rig.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 1, 20f);
            ballcontroll.shootSwitch = true;
            ball.hit = true;
            if (gamas.Inning2 == 0)
            {
                gamas.Team1Batter++;
            }
            else if (gamas.Inning2 == 1)
            {
                gamas.Team2Batter++;
            }

            gamas.Strike = 0;
            gamas.Runner++;

            if (gamas.Inning2 == 0 && 4 <= gamas.Runner)
            {
                gamas.AtkPt++;
                gamas.Runner = 3;

            }
            if (gamas.Inning2 == 1 && 4 <= gamas.Runner)
            {
                gamas.DefPt++;
                gamas.Runner = 3;
            }
        }
        else if (ball.foul == true || ball.out1 == true || ball.hit == true || ball.homerun == true)
        {
            time = 0;
            rig.velocity = Vector3.zero;
            rig.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 1, 20f);
            ballcontroll.shootSwitch = true;
        }
        if (ball.pitch == false && gamas.gameset == false && gamas.change == false && gamas.Wait == false)
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
            ballcontroll.shootSwitch = true;
        }
    }
}