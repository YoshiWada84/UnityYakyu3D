using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Out : MonoBehaviour
{
    public AudioSource OutAudio;
    public AudioClip OutSE;
    public GameTextes gamas;
    private float position_x = 6;//現在位置x
    private float position_y = 4;//現在位置y
    private float positioning_max_x = 20;//最大位置
    private float positioning_max_y = 30;//最大位置
    public int time_def = 200;


    
    public int currentTP=400;
    

    //private bool DP = false;//守備の値

   

    // Start is called before the first frame update
    void Start()
    {
        OutAudio = gameObject.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (gamas.change == true)
        {
            time_def = 400;
        }
        if (1 <= gamas.Inning)
        {
            transform.localScale = new Vector3(position_x, position_y, 1);
        }
        if (gamas.Inning2 == 0 && Input.GetMouseButton(0) && time_def >1)
        {
            transform.localScale = new Vector3(positioning_max_x, positioning_max_y, 1);
            time_def--;
        }
        if (gamas.Inning2 == 1 && Input.GetKey(KeyCode.A) &&time_def>1) 
        {
            transform.localScale = new Vector3(positioning_max_x, positioning_max_y, 1);
            time_def--;
        }
        

    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Ball")
        {

            gamas.Strike = 0;
            gamas.Out++;
            if (gamas.Inning2 == 0)
            {
                gamas.Team1Batter++;
            }
            else if (gamas.Inning2 == 1)
            {
                gamas.Team2Batter++;
            }

            OutAudio.PlayOneShot(OutSE);

        }
    }
}
