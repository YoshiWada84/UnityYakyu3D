using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class OutCPU : MonoBehaviour
{

    public ballcontroll ball;

    public GameTextes gamas;
    public batCPU cpus;

    public bool bigger = false;

    private float position_x = 6;//現在位置x
    private float position_y = 6;//現在位置y
    private float positioning_max_x = 20;//最大位置
    private float positioning_max_y = 50;//最大位置
    //public int time_def = 400;//テスト版
    public int time_def = 100;

    public Text OPText;        //OPテキスト

    private bool HPUP = false;

    public int currentTP = 400;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OPText.text = string.Format("DP：{0}", time_def);

        if (gamas.change == true)
        {
            time_def = 100;
        }




        if (1 <= gamas.Inning)
        {
            transform.localScale = new Vector3(position_x, position_y, 1);
            bigger = false;
        }

        if (gamas.Inning2 == 0 && time_def > 0 && (ball.transform.position.y >= 12))
        {
            transform.localScale = new Vector3(positioning_max_x, positioning_max_y, 12);
            time_def -= 2;
            bigger = true;
        }
        else if (gamas.Inning2 == 0 && time_def > 0 && (ball.transform.position.z >= 30))
        {
            transform.localScale = new Vector3(position_x * 2, position_y * 2, 9);
            time_def--;
            bigger = true;
        }
        if (gamas.Inning2 == 0 && time_def <= 0)
        {
            transform.localScale = new Vector3(position_x * 0.5f, position_y * 0.5f, 3);
        }
        else if (gamas.Inning2 == 1 && time_def <= 0)
        {
            transform.localScale = new Vector3(position_x * 0.5f, position_y * 0.5f, 3);
        }

        if (gamas.Inning2 == 1 && ((Input.GetMouseButton(0) && Input.GetMouseButton(1)) || (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.A))) && time_def > 0)
        {
            transform.localScale = new Vector3(positioning_max_x, positioning_max_y, 12);
            time_def -= 2;
        }
        else if (gamas.Inning2 == 1 && (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) && time_def > 0)
        {
            transform.localScale = new Vector3(position_x * 2, position_y * 2, 9);
            time_def--;
        }
        if ((ball.strike == true || ball.foul == true) && HPUP == false && ball.pitch == false)
        {
            HPUP = true;
            time_def += 10;
        }
        if ((ball.hit == true) && HPUP == false && ball.pitch == false)
        {
            HPUP = true;
            time_def += 20;
        }
        if ((ball.homerun == true) && HPUP == false && ball.pitch == false)
        {
            HPUP = true;
            time_def += 100;
        }
        if (ball.pitch == true)
        {
            HPUP = false;
        }
        if (time_def < 0)
        {
            time_def = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            ball.out1 = true;
            cpus.hit = false;
            ball.strike = false;
            ball.foul = false;
            ball.hit = false;
            ball.homerun = false;
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

            //gamas.CText.gameObject.SetActive(true);

        }
    }
}
  


