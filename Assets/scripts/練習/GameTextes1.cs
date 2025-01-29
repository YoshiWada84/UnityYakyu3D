using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTextes1 : MonoBehaviour
{
    public GameObject bat1;//バット
    public GameObject bat1L;//バット左
    

    public GameObject Bakugeki;//爆発
    public ballcontroll1 Ball;//ボール
   
    
    public GameObject Ground1;//グラウンド1
    

   

    public GameObject CText;//チェンジテキスト
    public GameObject CText2;//チェンジテキスト
    
    
    public Text StrikeText;     //ストライクカウント
    
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
        

        CText.gameObject.SetActive(false);
        CText2.gameObject.SetActive(true);


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Ball.hitBomb = false;
            Bakugeki.gameObject.SetActive(true);
        }
        
        if (Wait == true)
        {
            
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Title");

            }
            

        }
        
        #region//チーム
        if (Inning2 == 0&&Wait==false&&gameset==false)
        {
            
            
        }
        
        if (Inning2 == 1&&Wait==false && gameset == false)
        {
            bat1.gameObject.SetActive(false);
            bat1L.gameObject.SetActive(false);
            
            
        }
        
        if (Team1 == 0)
        {
            
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　からす");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　つばめ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　ふくろう", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　とり", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　いぬ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　さる", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　きじ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　こんどる", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　からす", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(true);
                bat1.SetActive(false);
                T1Text.text = string.Format("{0}　おに", Team1Batter);
            }

        }
        else if (Team1 == 1)
        {
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
            
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　{0}",Team3.batter9);
            }
            
            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter,Team3.batter1);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}" ,Team1Batter, Team3.batter2);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter3);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter4);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter5);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter6);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter7);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter8);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter9);
            }
        }
        else if (Team1 == 4)
        {
            
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　{0}", Team3.batter19);
            }

            if (Inning2 == 0 && Team1Batter == 1)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter11);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter12);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter13);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter14);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter15);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter16);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter17);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter18);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                bat1L.SetActive(false);
                bat1.SetActive(true);
                T1Text.text = string.Format("{0}　{1}", Team1Batter, Team3.batter19);
            }
        }
        
        #endregion
        #region//ランナー
        
        
        #endregion

        StrikeText.text = string.Format("S：{0}", Strike);//ストライクカウント
        

        

        //チェンジ処理を外す
        if (change == false && Wait == false)
        {
            CText.gameObject.SetActive(false);
        }
      
        if ( (Input.GetKey(KeyCode.Escape)))//タイトルに戻る
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

        if (Inning2 == 0) 
        {
            ScoreText.text = string.Format("1Pチーム　{0}\n2Pチーム　{1}", AtkPt, DefPt);//バックスクリーンスコア
        }
        else if (Inning2 == 1)
        {
            ScoreText.text = string.Format("1Pチーム　{0}\n2Pチーム　{1}", AtkPt, DefPt);//バックスクリーンスコア
        }     
        if (Ball.strike == true && ballcontroll1.shootSwitch == true && Ball.pitch == false && (Strike == 1 || Strike == 2) && gameset == false)//ストライク処理
        {
            ChangeText.text = string.Format("ストライク");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.strike == true && ballcontroll1.shootSwitch == true && Strike == 0 && change == false && gameset == false)//三振処理
        {
            ChangeText.text = string.Format("ストライク　バッターアウト");
            CText.gameObject.SetActive(true);
        }
        else if (Ball.foul == true && ballcontroll1.shootSwitch == true && gameset == false)//ファール処理
        {
            ChangeText.text = string.Format("ファール");
            CText.gameObject.SetActive(true);
        }

        else if (Ball.out1 == true && ballcontroll1.shootSwitch == true && change == false && gameset == false)//アウト処理
        {
            ChangeText.text = string.Format("アウト");
            CText.gameObject.SetActive(true);
            
        }
        //チェンジ処理
        else if (Ball.out1 == true && ballcontroll1.shootSwitch == true && change == true && gameset == false)
        {
            ChangeText.text = string.Format("攻守交代");
            CText.gameObject.SetActive(true);
        }
        //ヒット処理
        else if (Ball.hit == true && ballcontroll1.shootSwitch == true && gameset == false)
        {
            ChangeText.text = string.Format("ヒット");
            CText.gameObject.SetActive(true);
        }
        //ホームラン処理
        else if (Ball.homerun == true && ballcontroll1.shootSwitch == true && gameset == false)
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
        if (0 < Inning2)
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
