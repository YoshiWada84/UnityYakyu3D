using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutCPU : MonoBehaviour
{
    public AudioSource OutAudio;
    public AudioClip OutSE;
    public GameTextes gamas;
    public batCPU cpus;
    public ballcontroll BC;
    private float position_x = 6;//現在位置x
    private float position_y = 4;//現在位置y
    private float positioning_max_x = 15;//最大位置
    private float positioning_max_y = 50;//最大位置
    //public int time_def = 400;//テスト版
    public int time_def = 100;

    public Text OPText;        //OPテキスト

    public int currentTP = 400;

    // Start is called before the first frame update
    void Start()
    {
        OutAudio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        OPText.text = string.Format("DP：{0}", time_def);
        if (gamas.Inning2==0&&gamas.change == true)
        {
            //time_def = 400;//テスト版
            time_def = 100;
        }
        if (gamas.Inning2 == 1 && gamas.change == true)
        {
            //time_def = 400;//テスト版
            time_def = 100;
        }
        if ((gamas.Team1==2&&gamas.Inning2==1) && gamas.change == true)
        {
            time_def = 4000;
        }
        if ((gamas.Team2 == 2 && gamas.Inning2 == 0) && gamas.change == true)
        {
            time_def = 4000;
        }
        if (1 <= gamas.Inning)
        {
            transform.localScale = new Vector3(position_x, position_y, 1);

        }
        if (gamas.Inning2 == 0 && time_def > 0&&(BC.transform.position.z>=60|| BC.transform.position.y >= 8))
        {
            transform.localScale = new Vector3(positioning_max_x, positioning_max_y, 5); 
            time_def--;
        }
        if (gamas.Inning2 == 1 && (Input.GetMouseButton(0)|| Input.GetKey(KeyCode.Space)) && time_def > 0)
        {
            transform.localScale = new Vector3(positioning_max_x, positioning_max_y, 5);
            time_def--;
        }
        

    }
    void OnCollisionEnter(Collision collision)
    {
        
       
        if (collision.gameObject.tag == "Ball")
        {
            cpus.hit = false;
            gamas.Strike=0;
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
