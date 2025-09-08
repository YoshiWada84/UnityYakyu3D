using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTextes : MonoBehaviour
{
    public GameObject bat1;//バット
    public GameObject bat1yowai;//バット弱
    public GameObject bat1L;//バット左

    public GameObject bat2;//バット
    public GameObject bat2yowai;//バット弱
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
    public GameObject CText2;//チェンジテキスト

    //BGM
    public GameObject BGM1;
    public GameObject BGM2;
    public GameObject BGM3;
    public GameObject BGM4;
    public GameObject BGM5;//サヨナラ限定


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
    public bool game=false;      //9回にするか

    public bool Win;      //勝
    public bool Lose;     //敗

    public EnterName Team3;
    public bool music5 = false;
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
        Def2.gameObject.SetActive(false);

        CText.gameObject.SetActive(false);
        CText2.gameObject.SetActive(true);


        BGM1.gameObject.SetActive(true);
        BGM2.gameObject.SetActive(false);
        BGM3.gameObject.SetActive(false);
        BGM4.gameObject.SetActive(false);
        BGM5.gameObject.SetActive(false);
        music5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Alpha0))
        //{
        //    Ball.hitBomb = false;
        //    Bakugeki.gameObject.SetActive(true);
        //}
        if (Wait == true)
        {
            
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Title");

            }
            InningText.text = string.Format("");
            if (Team1==0)
            {
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(false);

            }
            else if (Team1 == 1)
            {
                Ground1.gameObject.SetActive(true);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(false);

            }
            else if (Team1 == 2)
            {
               
                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(true);
                Ground3.gameObject.SetActive(false);
            }
            else if (Team1 == 3)
            {

                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);


            }
            else if (Team1 == 4)
            {

                Ground1.gameObject.SetActive(false);
                Ground2.gameObject.SetActive(false);
                Ground3.gameObject.SetActive(true);


            }

            


        }
        if (Inning2 == 0 && Wait == false && gameset == false)
        {
            bat2yowai.SetActive(false);
            bat2.gameObject.SetActive(false);
            bat2L.gameObject.SetActive(false);
        }
        else if (Inning2 == 1 && Wait == false && gameset == false)
        {
            bat1yowai.SetActive(false);
            bat1.gameObject.SetActive(false);
            bat1L.gameObject.SetActive(false);
        }
        #region//チーム
        if (Inning2 == 0&&Wait==false&&gameset==false)
        {

            
            if (3 < Inning&&game==false)//延長処理(3回制)
            {
                InningText.text = string.Format("延長{0}回表", Inning);
            }
            else if (9 < Inning && game == true)//延長処理(9回制)
            {
                InningText.text = string.Format("延長{0}回表", Inning);
            }
            else//イニング処理(その他)
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
            if (3 < Inning&& game == false)//延長処理(3回制)
            {
                InningText.text = string.Format("延長{0}回裏", Inning);
            }
            else if (9 < Inning && game == true)//延長処理(9回制)
            {
                InningText.text = string.Format("延長{0}回裏", Inning);
            }
            else//イニング処理
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
            AttackText.text = string.Format("エトワール選抜：{0}", AtkPt);

            if (Inning2 == 1)
            {
                if ((game == true && Inning < 7) || (game == false && Inning < 4))
                {
                    T1Text.text = string.Format("P　そのだ");
                }
                else
                {
                    T1Text.text = string.Format("P　こまつ");
                }
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
               
                if ((game == true && 6 < Inning) || (game == false && 3 < Inning))
                {
                    bat1L.SetActive(false);
                    bat1.SetActive(true);
                    bat1yowai.SetActive(false);
                    T1Text.text = string.Format("{0}　やまざき", Team1Batter);
                }
                else
                {
                    bat1L.SetActive(false);
                    bat1.SetActive(false);
                    bat1yowai.SetActive(true);
                    T1Text.text = string.Format("{0}　ほんさこ", Team1Batter);
                }
                
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　ふじおか", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　やまだ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　ささき", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　ながお", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　いしばし", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　わだ　ゆ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}　わだ　し", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                if ((game == true && Inning < 7) || (game == false && Inning < 4))
                {
                    bat1L.SetActive(true);
                    bat1.SetActive(false);
                    bat1yowai.SetActive(false);
                    T1Text.text = string.Format("{0}　そのだ", Team1Batter);
                }
                else
                {
                    bat1L.SetActive(true);
                    bat1.SetActive(false);
                    bat1yowai.SetActive(false);
                    T1Text.text = string.Format("{0}　こまつ", Team1Batter);
                }
            }

        }
        else if (Team1 == 1)
        {
            AttackText.text = string.Format("エトワールBC：{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　なゆた");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さがね", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　にしさか　と", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　いとう", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　ありた", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　わだ　よ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}　かわさき", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　しもた", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}　にしさか　け", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　なゆた", Team1Batter);
            }
        }
        else if (Team1 == 2)
        {
            AttackText.text = string.Format("ゴリラーズ：{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　さいきょうP");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);

                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょうCF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょうRF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょうSS", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょうLF", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょう3B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょう1B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょうC", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(false);
                bat1yowai.SetActive(true);
                T1Text.text = string.Format("{0}　さいきょう2B", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　さいきょうP", Team1Batter);
            }

        }
        else if (Team1 == 3)
        {
            AttackText.text = string.Format("{1}：{0}", AtkPt,Team3.batter0);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　{0}",Team3.batter9);
            }
            
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter,Team3.batter1);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}" ,Team1Batter, Team3.batter2);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter3);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter4);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter5);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter6);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter7);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter8);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter9);
            }
        }
        else if (Team1 == 4)
        {
            AttackText.text = string.Format("{1}：{0}", AtkPt,Team3.batter10);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　{0}", Team3.batter19);
            }

            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter11);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter12);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter13);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter14);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter15);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter16);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter17);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter18);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                bat1yowai.SetActive(false);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter19);
            }
        }
        else
        {
            AttackText.text = string.Format("先攻チーム：{0}", AtkPt);
        }
        if (Team2 == 0)
        {
            DeffenceText.text = string.Format("エトワール選抜：{0}", DefPt);
            if (Inning2 == 0)
            {
                if ((game == true && Inning < 7) || (game == false && Inning < 4)) 
                {
                    T2Text.text = string.Format("P　そのだ");
                }
                else
                {
                    T2Text.text = string.Format("P　こまつ");
                }
                
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
               
                if ((game == true && 6 < Inning) || (game == false && 3 < Inning))
                {
                    bat2L.SetActive(false);
                    bat2.SetActive(true);
                    bat2yowai.SetActive(false);
                    T2Text.text = string.Format("{0}　やまざき", Team2Batter);
                }
                else
                {
                    bat2L.SetActive(false);
                    bat2.SetActive(false);
                    bat2yowai.SetActive(true);
                    T2Text.text = string.Format("{0}　ほんさこ", Team2Batter);
                }
                    
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　ふじおか", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　やまだ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　ささき", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　ながお", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　いしばし", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　わだ　ゆ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
                T2Text.text = string.Format("{0}　わだ　し", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                
                if ((game == true && Inning < 7) || (game == false && Inning < 4))
                {
                    bat2L.SetActive(true);
                    bat2.SetActive(false);
                    bat2yowai.SetActive(false);
                    T2Text.text = string.Format("{0}　そのだ", Team2Batter);
                }
                else
                {
                    bat2L.SetActive(true);
                    bat2.SetActive(false);
                    bat2yowai.SetActive(false);
                    T2Text.text = string.Format("{0}　こまつ", Team2Batter);
                }
            }
        }
        else if (Team2 == 1)
        {
            DeffenceText.text = string.Format("エトワールBC：{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　なゆた");
                

            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さがね", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　にしさか　と", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　いとう", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　ありた", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　わだ　よ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
                T2Text.text = string.Format("{0}　かわさき", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　しもた", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
                T2Text.text = string.Format("{0}　にしさか　け", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　なゆた", Team2Batter);
            }
        }
        else if (Team2 == 2)
        {
            DeffenceText.text = string.Format("ゴリラーズ：{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　さいきょうP");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょうCF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(false);
                bat2yowai.SetActive(true);
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
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょうLF", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょう3B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(true);
                bat2.SetActive(false);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょう1B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょうC", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょう2B", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　さいきょうP", Team2Batter);
            }
        }
        else if (Team2 == 3)
        {
            DeffenceText.text = string.Format("{1}：{0}", DefPt,Team3.batter0);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　{0}",Team3.batter9);
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter,Team3.batter1);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter2);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter3);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter4);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter5);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter6);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter7);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter8);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter9);
            }
        }
        else if (Team2 == 4)
        {
            DeffenceText.text = string.Format("{1}：{0}", DefPt,Team3.batter10);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　{0}", Team3.batter19);
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter11);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter12);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter13);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter14);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter15);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter16);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter17);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter18);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                bat2L.SetActive(false);
                bat2.SetActive(true);
                bat2yowai.SetActive(false);
                T2Text.text = string.Format("{0}　{1}", Team2Batter, Team3.batter19);
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

        StrikeText.text = string.Format("S：{0}", Strike);//ストライクカウント
        OutText.text = string.Format("O：{0}", Out);//アウトカウント

        #region//試合終了判定、タイブレーク処理
        //タイブレーク
        if (game == false)
        {
            if (4 <= Inning && change == true)//大会仕様
            {
                Runner = 2;
            }
        }
        else if (game == true)
        {
            if (10 <= Inning && change == true)
            {
                Runner = 2;
            }
        }

        //チェンジ処理を外す
        if (change == false && Wait == false)
        {
            CText.gameObject.SetActive(false);
        }
        //試合終了判定
        if (gameset == true)
        {
            sec2++;
        }
        if (game == false) {
            if (6 <= Inning)//大会仕様
            {
                gameset = true;
                ChangeText.text = string.Format("試合終了\n" +
                    "Spaceキーまたは左マウスでタイトルに戻る");
                CText.gameObject.SetActive(true);
                InningText.text = string.Format("試合終了");

                StrikeText.text = string.Format("引き分け");
                OutText.text = string.Format("");
                BGM4.gameObject.SetActive(true);
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

            }
            else if ((3 <= Inning && Inning2 == 1 && (AtkPt < DefPt)) || (AtkPt - DefPt <= -7))
            {
                gameset = true;
                ChangeText.text = string.Format("試合終了\n" +
                    "Spaceキーまたは左マウスでタイトルに戻る");
                CText.gameObject.SetActive(true);
                InningText.text = string.Format("試合終了");
                
                StrikeText.text = string.Format("2Ｐの勝ち");
                OutText.text = string.Format("");
                if (Ball.homerun == true)
                {
                    music5 = true;
                    BGM5.gameObject.SetActive(true);
                }
                else if(music5==false)
                {
                    BGM4.gameObject.SetActive(true);
                }
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

                Lose = true;
            }
            else if ((4 <= Inning && Inning2 == 0&&change==true && (AtkPt > DefPt))||(Inning2==0&&change==true&& AtkPt - DefPt >= 7) ||AtkPt - DefPt >= 10)
            {
                gameset = true;
                ChangeText.text = string.Format("試合終了\n" +
                    "Spaceキーまたは左マウスでタイトルに戻る");
                CText.gameObject.SetActive(true);

                InningText.text = string.Format("試合終了");

                StrikeText.text = string.Format("1Ｐの勝ち");
                OutText.text = string.Format("");
                BGM4.gameObject.SetActive(true);
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

                Win = true;
            }
        }
        else if (game == true)
        {
            if ((9 <= Inning && Inning2 == 1 &&change==true&& (AtkPt < DefPt) || (AtkPt - DefPt <= -10))||(9 <= Inning&& Inning2 == 1 && (AtkPt < DefPt)))
            {
                gameset = true;
                ChangeText.text = string.Format("試合終了\n" +
                    "Spaceキーまたは左マウスでタイトルに戻る");
                CText.gameObject.SetActive(true);
                InningText.text = string.Format("試合終了");
                StrikeText.text = string.Format("2Ｐの勝ち");
                OutText.text = string.Format("");

                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);
                if (Ball.homerun == true)
                {
                    music5 = true;
                    BGM5.gameObject.SetActive(true);
                }
                else if (music5 == false)
                {
                    BGM4.gameObject.SetActive(true);
                }
                Lose = true;
            }
            else if ((10 <= Inning && change == true && Inning2 == 0 && (AtkPt > DefPt)) || (Inning2 == 0 && change == true && AtkPt - DefPt >= 10))
            {
                gameset = true;
                ChangeText.text = string.Format("試合終了\n" +
                    "Spaceキーまたは左マウスでタイトルに戻る");
                CText.gameObject.SetActive(true);


                StrikeText.text = string.Format("1Ｐの勝ち");

                OutText.text = string.Format("");

                BGM4.gameObject.SetActive(true);
                BGM1.gameObject.SetActive(false);
                BGM2.gameObject.SetActive(false);
                BGM3.gameObject.SetActive(false);

                Win = true;
            }
        }
        if (gameset == true && 300 < sec2 && (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)))//タイトルに戻る
        {
            SceneManager.LoadScene("Title");
        }
        //試合時間処理(使っていない)
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
        if (Inning2 == 0&&change==true&&Wait==false)//攻守交代処理
        {
            Def1.gameObject.SetActive(true);
            Def2.gameObject.SetActive(false);
        }
        else if (Inning2 == 1 && change == true && Wait == false)//攻守交代処理
        {
            Def1.gameObject.SetActive(false);
            Def2.gameObject.SetActive(true);
        }
        if (Ball.strike == true && ballcontroll.shootSwitch == true && Ball.pitch == false && (Strike == 1 || Strike == 2) && gameset == false)//ストライク処理
        {
            ChangeText.text = string.Format("ストライク");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.strike == true && ballcontroll.shootSwitch == true && Strike == 0 && change == false && gameset == false)//三振処理
        {
            ChangeText.text = string.Format("ストライク　バッターアウト");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.foul == true && ballcontroll.shootSwitch == true && gameset == false)//ファール処理
        {
            ChangeText.text = string.Format("ファール");
            CText.gameObject.SetActive(true);
        }

        else if (Ball.out1 == true && ballcontroll.shootSwitch == true && change == false && gameset == false)//アウト処理
        {
            ChangeText.text = string.Format("アウト");
            CText.gameObject.SetActive(true);
            
        }
        //チェンジ処理
        else if (Ball.out1 == true && ballcontroll.shootSwitch == true && change == true && gameset == false)
        {
            ChangeText.text = string.Format("攻守交代");
            CText.gameObject.SetActive(true);
        }
        //ヒット処理
        else if (Ball.hit == true && ballcontroll.shootSwitch == true && gameset == false)
        {
            ChangeText.text = string.Format("ヒット");
            CText.gameObject.SetActive(true);
        }
        //ホームラン処理
        else if (Ball.homerun == true && ballcontroll.shootSwitch == true && gameset == false)
        {
            ChangeText.text = string.Format("ホームラン");
            CText.gameObject.SetActive(true);
        }
        //投球処理
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
        //ストライク、三振処理
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
        //チェンジ処理
        if (2 < Out)
        {
            
            Out = 0;
            Runner = 0;
            Inning2++;
            Ball.hitBomb = false;
            change = true;
            Bakugeki.SetActive(true);
        }
        //攻守交代処理(裏から表)
        if (1 < Inning2)
        {
            Inning2 = 0;
            Inning++;
        }
        //打順処理
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
