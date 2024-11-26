using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTextes : MonoBehaviour
{
    public GameObject bat1;//バット
    public GameObject bat1L;//バット左
    public GameObject bat2;//バット
    public GameObject bat2L;//バット左

    public GameObject Bakugeki;//爆発
    public ballcontroll Ball;//ボール
    public GameObject Runner1;//ランナー
    public GameObject Runner2;//ランナー
    public GameObject Runner3;//ランナー

    public GameObject Runner4;//ランナー
    public GameObject Runner5;//ランナー
    public GameObject Runner6;//ランナー

    public GameObject Ground1;//グラウンド1
    public GameObject Ground2;//グラウンド2
    public GameObject Ground3;//グラウンド3

    public GameObject Def1;//守備オブジェクト1
    public GameObject Def2;//守備オブジェクト2


    public GameObject CText;//チェンジテキスト


    //BGM
    public GameObject BGM1;
    public GameObject BGM2;
    public GameObject BGM3;
    public GameObject BGM4;


    public Text InningText;     //回数
    public Text AttackText;     //先攻チームの得点
    public Text DeffenceText;   //後攻チームの得点
    public Text RunnerText;     //ランナー
    public Text StrikeText;     //ストライクカウント
    public Text OutText;        //アウトカウント
    public Text ScoreText;        //スコアテキスト
    public Text T1Text;        //選手1テキスト
    public Text T2Text;        //選手2テキスト
    public Text ChangeText;    //チェンジテキスト

    public int hour = 0;       //時間
    public int min = 0;         //分
    public int sec = 0;         //秒

    public int sec2 = 0;         //秒

    public int hithit = 0;

    public int Inning;      //回数
    public int Inning2;     //表裏
    public int Team1;       //チーム先攻
    public int Team2;       //チーム後攻
    public int Team1Batter;       //チーム先攻2
    public int Team2Batter;       //チーム後攻2
    

    public int AtkPt;       //先攻チームの得点数
    public int DefPt;       //後攻チームの得点数
    public int Runner;      //ランナー
    public int Strike;      //ストライク数
    public int Out;         //アウトの数
    public bool gameset;    //試合終了か否か
    public bool change;    //攻守交替
    public bool Wait;      //チーム決め

    public bool Win;      //勝
    public bool Lose;     //敗

    //BGM



    // Start is called before the first frame update
    void Start()
    {
        //試合関連
        Inning = 1;
        Inning2 = 0;
        Team1 = 0;
        Team2 = 1;
        AtkPt = 0;
        DefPt = 0;
        Runner = 0;
        Strike = 0;
        Out = 0;
        Team1Batter = 1;
        Team2Batter = 1;
        gameset = false;
        change = false;
        Wait = true; 
        Ground1.gameObject.SetActive(true);
        Ground2.gameObject.SetActive(false);
        Ground3.gameObject.SetActive(false);
        Def1.gameObject.SetActive(true);
        Def2.gameObject.SetActive(true);

        CText.gameObject.SetActive(true);


        BGM1.gameObject.SetActive(true);
        BGM2.gameObject.SetActive(false);
        BGM3.gameObject.SetActive(false);
        BGM4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Wait == true)
        {
            
            InningText.text = string.Format("SPACEキーでスタート");
            if (Input.GetKey(KeyCode.Alpha1))
            {
                Team1 = 0;
                Team2 = 1;
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(false);

            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                Team1 = 0;
                Team2 = 2;
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(false);

            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                Team1 = 0;
                Team2 = 3;
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(false);


            }
            else if (Input.GetKey(KeyCode.Alpha4))
            {
                Team1 = 1;
                Team2 = 0;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                Ground3.gameObject.SetActive(false);



            }
            else if (Input.GetKey(KeyCode.Alpha5))
            {
                Team1 = 1;
                Team2 = 2;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                Ground3.gameObject.SetActive(false);

            }
            else if (Input.GetKey(KeyCode.Alpha6))
            {
                Team1 = 1;
                Team2 = 3;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                Ground3.gameObject.SetActive(false);

            }
            else if (Input.GetKey(KeyCode.Alpha7))
            {
                Team1 = 2;
                Team2 = 0;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);

            }
            else if (Input.GetKey(KeyCode.Alpha8))
            {
                Team1 = 2;
                Team2 = 1;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);

            }
            else if (Input.GetKey(KeyCode.Alpha9))
            {
                Team1 = 3;
                Team2 = 0;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);

            }
            else if (Input.GetKey(KeyCode.Alpha0))
            {
                Team1 = 3;
                Team2 = 1;
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);
            }
            else if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Title");

            }



        }
        if (Wait == true&&Input.GetKey(KeyCode.Space))
        {
            CText.gameObject.SetActive(false);
            Wait = false;
            change = true;
            hour = 0;
            min = 0;
            sec = 0;
            Ball.timer = 0;
            BGM1.gameObject.SetActive(false);
            

        }
        #region//チーム
        if (Inning2 == 0&&Wait==false&&gameset==false)
        {
            
            bat2.gameObject.SetActive(false);
            bat2L.gameObject.SetActive(false);
            if (3 < Inning)
            {
                InningText.text = string.Format("延長{0}回表", Inning);
            }
            else
            {
                InningText.text = string.Format("{0}回表", Inning);
            }
            BGM2.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM3.gameObject.SetActive(false);
            BGM4.gameObject.SetActive(false);

        }
        
        if (Inning2 == 1&&Wait==false && gameset == false)
        {
            bat1.gameObject.SetActive(false);
            bat1L.gameObject.SetActive(false);
            if (3 < Inning)
            {
                InningText.text = string.Format("延長{0}回裏", Inning);
            }
            else
            {
                InningText.text = string.Format("{0}回裏", Inning);
            }
            BGM3.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM2.gameObject.SetActive(false);
            BGM4.gameObject.SetActive(false);
            
        }
        
        if (Team1 == 0)
        {
            AttackText.text = string.Format("たいがーす：{0}", AtkPt);

            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　とらかみ");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　とらもと", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　とらの", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　もりとら", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　とらやま", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　さとら", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　とらがわ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　さかとら", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　とらみ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　とらかみ", Team1Batter);
            }

        }
        else if (Team1 == 1)
        {
            AttackText.text = string.Format("ぺりーず：{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　タイラー");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　あきる", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　おかだ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　あきやま", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　バーサーク", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　レアンドロ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　とやま", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　おおしろ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　うめもと", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　タイラー", Team1Batter);
            }
        }
        else if (Team1 == 2)
        {
            AttackText.text = string.Format("ゴスペラーズ：{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　さいきょうP");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょうCF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょうRF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょうSS", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょうLF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょう3B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょう1B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょうC", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょう2B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょうP", Team1Batter);
            }

        }
        else if (Team1 == 3)
        {
            AttackText.text = string.Format("ポリゴンズ：{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　？？？");
            }
            
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　？？？", Team1Batter);
            }
        }

        else
        {
            AttackText.text = string.Format("先攻チーム：{0}", AtkPt);
        }
        if (Team2 == 0)
        {
            DeffenceText.text = string.Format("たいがーす：{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　とらざき");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　とらもと", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　とらの", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　もりとら", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　とらやま", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　さとら", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　とらうえ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　うめとら", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　おばとら", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　とらざき", Team2Batter);
            }
        }
        else if (Team2 == 1)
        {
            DeffenceText.text = string.Format("ぺりーず：{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　おはら");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　あきる", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　おかだ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　あきやま", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　バーサーク", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　レアンドロ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　とやま", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　おおしろ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　うめもと", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　おはら", Team2Batter);
            }
        }
        else if (Team2 == 2)
        {
            DeffenceText.text = string.Format("ゴスペラーズ：{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　さいきょうP");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　さいきょうCF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　さいきょうRF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょうSS", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょうLF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　さいきょう3B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょう1B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　さいきょうC", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　さいきょう2B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　さいきょうP", Team2Batter);
            }
        }
        else if (Team2 == 3)
        {
            DeffenceText.text = string.Format("ポリゴンズ：{0}", AtkPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　？？？");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                T2Text.text = string.Format("{0}　？？？", Team2Batter);
            }
        }
        else
        {
            DeffenceText.text = string.Format("後攻チーム：{0}", DefPt);
            bat2L.SetActive(false);
            bat2.SetActive(true);
        }
        #endregion
        #region//ランナー
        if (Inning2 == 0)
        {
            if (Runner == 0)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("ランナーなし");
            }
            else if (Runner == 1)
            {
                Runner1.SetActive(true);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("ランナー１塁");
            }
            else if (Runner == 2)
            {
                Runner1.SetActive(true);
                Runner2.SetActive(true);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("ランナー１,２塁");
            }
            else if (Runner == 3)
            {
                Runner1.SetActive(true);
                Runner2.SetActive(true);
                Runner3.SetActive(true);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("ランナー満塁");
            }
        }
        else if (Inning2 == 1)
        {
            if (Runner == 0)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(false);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("ランナーなし");
            }
            else if (Runner == 1)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(true);
                Runner5.SetActive(false);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("ランナー１塁");
            }
            else if (Runner == 2)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(true);
                Runner5.SetActive(true);
                Runner6.SetActive(false);
                RunnerText.text = string.Format("ランナー１,２塁");
            }
            else if (Runner == 3)
            {
                Runner1.SetActive(false);
                Runner2.SetActive(false);
                Runner3.SetActive(false);
                Runner4.SetActive(true);
                Runner5.SetActive(true);
                Runner6.SetActive(true);
                RunnerText.text = string.Format("ランナー満塁");
            }
        }
        #endregion

        StrikeText.text = string.Format("S：{0}", Strike);
        OutText.text = string.Format("O：{0}", Out);

        #region//試合終了判定、タイブレーク処理
        //タイブレーク
        if (4 <= Inning && change == true)
        {
            Runner = 2;
        }

        #region//チェンジ処理
        if (change == true&& (Strike==0||Ball.out1==true)&&gameset==false&&1<min)
        {
            ChangeText.text = string.Format("攻守交代");
            CText.gameObject.SetActive(true);
        }
        if (change == true && gameset == true)
        {
            
            ChangeText.text = string.Format("試合終了\n" +
                "Spaceキーまたは左マウスでタイトルに戻る");
            CText.gameObject.SetActive(true);
        }
        if (change == false&&Wait==false)
        {
            CText.gameObject.SetActive(false);
        }
        #endregion

        //試合終了判定
        if (gameset == true)
        {
            sec2++;
        }
        if ((3 <= Inning && Inning2 == 1 && (AtkPt < DefPt)) || ( AtkPt - DefPt <= -7))
        {
            gameset = true;
            InningText.text = string.Format("試合終了");
            if (Team2 == 0)
            {
                StrikeText.text = string.Format("たいがーすの勝ち");
            }
            else if (Team2 == 1)
            {
                StrikeText.text = string.Format("ぺりーずの勝ち");
            }
            else if (Team2 == 2)
            {
                StrikeText.text = string.Format("ゴスペラーズの勝ち");
            }
            else
            {
                StrikeText.text = string.Format("後攻チームの勝ち");
            }
            OutText.text = string.Format("");
            
            BGM4.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM2.gameObject.SetActive(false);
            BGM3.gameObject.SetActive(false);

            Lose = true;
        }
        else if ((4 <= Inning && Inning2 == 0 && (AtkPt > DefPt) && change == true)||(Inning2==0 && change == true && AtkPt - DefPt>=7)|| AtkPt - DefPt >= 10)
        {
            gameset = true;
            InningText.text = string.Format("試合終了");
            if (Team1 == 0)
            {
                StrikeText.text = string.Format("たいがーすの勝ち");
            }
            else if (Team1 == 1)
            {
                StrikeText.text = string.Format("ぺりーずの勝ち");
            }
            else if (Team1 == 2)
            {
                StrikeText.text = string.Format("ゴスペラーズの勝ち");
            }
            else
            {
                StrikeText.text = string.Format("先攻チームの勝ち");
            }

            OutText.text = string.Format("");
            
            BGM4.gameObject.SetActive(true);
            BGM1.gameObject.SetActive(false);
            BGM2.gameObject.SetActive(false);
            BGM3.gameObject.SetActive(false);

            Win = true;
        }

        if (gameset == true && 300 < sec2 && (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)))
        {
            SceneManager.LoadScene("Title");
        }
        if (gameset == false)
        {
            sec++;
        }

        if (1000 <= sec)
        {
            min++;
            sec = 0;
        }
        if (60 <= min)
        {
            hour++;
            min = 0;
        }

        #endregion
        if (Inning2 == 0) 
        {
            ScoreText.text = string.Format("{0}回表\n{1}　-　{2}", Inning,AtkPt, DefPt);//バックスクリーンスコア
        }
        else if (Inning2 == 1)
        {
            ScoreText.text = string.Format("{0}回裏\n{1}　-　{2}", Inning, AtkPt, DefPt);//バックスクリーンスコア
        }
        if (Inning2 == 0&&change==false&&Wait==false)
        {
            Def1.gameObject.SetActive(true);
            Def2.gameObject.SetActive(false);
        }
        else if (Inning2 == 1 && change == false && Wait == false)
        {
            Def1.gameObject.SetActive(false);
            Def2.gameObject.SetActive(true);
        }
        if (Ball.strike==true&&Ball.pitch==false&&(Strike==1||Strike==2) && gameset == false)
        {
            ChangeText.text = string.Format("ストライク");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.strike == true && Ball.pitch == false &&Strike==0&&change==false&&gameset==false)
        {
            ChangeText.text = string.Format("ストライク　バッターアウト");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.foul == true && Ball.pitch == false && gameset == false)
        {
            ChangeText.text = string.Format("ファール");
            CText.gameObject.SetActive(true);
        }

        else if (Ball.out1 == true && Ball.pitch == false&&change==false && gameset == false)
        {
            ChangeText.text = string.Format("アウト");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.hit == true && Ball.pitch == false && gameset == false)
        {
            ChangeText.text = string.Format("ヒット");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.homerun == true && Ball.pitch == false && gameset == false)
        {
            ChangeText.text = string.Format("ホームラン");
            CText.gameObject.SetActive(true);
        }

        if (Ball.pitch==true)
        {
            Ball.strike = false;
            Ball.foul = false;
            Ball.out1 = false;
            Ball.hit = false;
            Ball.homerun = false;
            CText.gameObject.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        if (2 < Strike)
        {
            Strike = 0;
            Out++;
            if (Inning2 == 0)
            {
                Team1Batter++;
            }
            else if (Inning2 == 1)
            {
                Team2Batter++;
            }
        }
        if (2 < Out)
        {
            
            Out = 0;
            Runner = 0;
            Inning2++;
            Ball.hitBomb = false;
            change = true;
            Bakugeki.SetActive(true);
        }
        if (1 < Inning2)
        {
            Inning2 = 0;
            Inning++;
        }
        if (9 < Team1Batter)
        {
            Team1Batter = 1;
        }
        if (9 < Team2Batter)
        {
            Team2Batter = 1;
        }
    }
}
