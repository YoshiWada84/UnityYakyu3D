using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextes : MonoBehaviour
{
    public GameObject bat1;//バット
    public GameObject bat2;//バット

    public Text InningText;     //回数
    public Text AttackText;     //先攻チームの得点
    public Text DeffenceText;   //後攻チームの得点
    public Text RunnerText;     //ランナー
    public Text StrikeText;     //ストライクカウント
    public Text OutText;        //アウトカウント
    public Text ScoreText;        //スコアテキスト
    public Text T1Text;        //選手1テキスト
    public Text T2Text;        //選手2テキスト

    public int hour = 0;       //時間
    public int min = 0;         //分
    public int sec = 0;         //秒


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

    

    // Start is called before the first frame update
    void Start()
    {
        //試合関連
        Inning = 1;
        Inning2 = 1;
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

        
}

// Update is called once per frame
void Update()
    {
        if (Inning2 == 0)
        {
            bat1.gameObject.SetActive(true);
            bat2.gameObject.SetActive(false);
            InningText.text = string.Format("{0}回表", Inning);
            if (Team2 == 0)
            {
                T2Text.text = string.Format("P　むら");
            }
            else if (Team2 == 1)
            {
                T2Text.text = string.Format("P　こま");
            }
            else
            {
                T2Text.text = string.Format("P　選手名");
            }

        }
        if (Inning2 == 1)
        {
            bat1.gameObject.SetActive(false);
            bat2.gameObject.SetActive(true);
            InningText.text = string.Format("{0}回裏", Inning);
            if (Team1 == 0)
            {
                T1Text.text = string.Format("P　ざき");
            }
            else if (Team1 == 1)
            {
                T1Text.text = string.Format("P　こま");

            }
            else
            {
                T1Text.text = string.Format("P　選手名");
            }
        }
        if (Team1 == 0)
        {
            AttackText.text = string.Format("たいがーす：{0}", AtkPt);

            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　むら"); 
            }
            if (Inning2 == 0&& Team1Batter == 1)
            {
                T1Text.text = string.Format("{0}　ちか",Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                T1Text.text = string.Format("{0}　なか", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                T1Text.text = string.Format("{0}　もり", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                T1Text.text = string.Format("{0}　やま", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                T1Text.text = string.Format("{0}　てる", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                T1Text.text = string.Format("{0}　まえ", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                T1Text.text = string.Format("{0}　さか", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                T1Text.text = string.Format("{0}　きな", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                T1Text.text = string.Format("{0}　むら", Team1Batter);
            }

        }
        else if (Team1 == 1)
        {
            AttackText.text = string.Format("ぺりーず：{0}", AtkPt);
            if (Inning2 == 1)
            {
                T1Text.text = string.Format("P　こま");
            }
            if (Inning2 == 0 && Team1Batter == 1)
            {
                T1Text.text = string.Format("{0}　いと", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 2)
            {
                T1Text.text = string.Format("{0}　よし", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 3)
            {
                T1Text.text = string.Format("{0}　はし", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 4)
            {
                T1Text.text = string.Format("{0}　にしとし", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 5)
            {
                T1Text.text = string.Format("{0}　たき", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 6)
            {
                T1Text.text = string.Format("{0}　さが", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 7)
            {
                T1Text.text = string.Format("{0}　こま", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 8)
            {
                T1Text.text = string.Format("{0}　にしけん", Team1Batter);
            }
            else if (Inning2 == 0 && Team1Batter == 9)
            {
                T1Text.text = string.Format("{0}　さこ", Team1Batter);
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
                T2Text.text = string.Format("P　ざき");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                T2Text.text = string.Format("{0}　ちか", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                T2Text.text = string.Format("{0}　なか", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                T2Text.text = string.Format("{0}　もり", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                T2Text.text = string.Format("{0}　やま", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                T2Text.text = string.Format("{0}　てる", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                T2Text.text = string.Format("{0}　まえ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                T2Text.text = string.Format("{0}　うめ", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                T2Text.text = string.Format("{0}　きな", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                T2Text.text = string.Format("{0}　ざき", Team2Batter);
            }
        }
        else if (Team2 == 1)
        {
            DeffenceText.text = string.Format("ぺりーず：{0}", DefPt);
            if (Inning2 == 0)
            {
                T2Text.text = string.Format("P　こま");
            }
            if (Inning2 == 1 && Team2Batter == 1)
            {
                T2Text.text = string.Format("{0}　いと", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 2)
            {
                T2Text.text = string.Format("{0}　よし", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 3)
            {
                T2Text.text = string.Format("{0}　はし", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 4)
            {
                T2Text.text = string.Format("{0}　にしとし", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 5)
            {
                T2Text.text = string.Format("{0}　たき", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 6)
            {
                T2Text.text = string.Format("{0}　さが", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 7)
            {
                T2Text.text = string.Format("{0}　こま", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 8)
            {
                T2Text.text = string.Format("{0}　にしけん", Team2Batter);
            }
            else if (Inning2 == 1 && Team2Batter == 9)
            {
                T2Text.text = string.Format("{0}　さこ", Team2Batter);
            }
        }
        else
        {
            DeffenceText.text = string.Format("後攻チーム：{0}", DefPt);
        }

        if (Runner == 0)
        {
            RunnerText.text = string.Format("ランナーなし");
        }
        else if (Runner == 1)
        {
            RunnerText.text = string.Format("ランナー１塁");
        }
        else if (Runner == 2)
        {
            RunnerText.text = string.Format("ランナー１,２塁");
        }
        else if (Runner == 3)
        {
            RunnerText.text = string.Format("ランナー満塁");
        }

        StrikeText.text=    string.Format("S：{0}",Strike);
        OutText.text=       string.Format("O：{0}", Out);

        //試合終了判定
        if (3 <= Inning && Inning2 == 1 && (AtkPt < DefPt))
        {
            InningText.text = string.Format("試合終了");
            if (Team2 == 0)
            {
                StrikeText.text = string.Format("たいがーすの勝ち");
            }
            else if (Team2 == 1)
            {
                StrikeText.text = string.Format("ぺりーずの勝ち");
            }
            else
            {
                StrikeText.text = string.Format("後攻チームの勝ち");
            }
            OutText.text = string.Format("");
            gameset = true;


        }
        else if (4 <= Inning && Inning2 == 0 && (AtkPt > DefPt) && change == true) 
        {
            InningText.text = string.Format("試合終了");
            if (Team1 == 0)
            {
                StrikeText.text = string.Format("たいがーすの勝ち");
            }
            else if (Team1 == 1)
            {
                StrikeText.text = string.Format("ぺりーずの勝ち");
            }
            else
            {
                StrikeText.text = string.Format("先攻チームの勝ち");
            }
            
            OutText.text = string.Format("");
            gameset = true;
        }
        else if (7 <= Inning && (AtkPt == DefPt))
        {
            InningText.text = string.Format("試合終了");
            StrikeText.text = string.Format("引き分け");
            OutText.text = string.Format("");
            gameset = true;
        }
        if (gameset==false) 
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

        
        ScoreText.text = string.Format("{0}　-　{1}",AtkPt,DefPt);//バックスクリーンスコア
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
            change = true;
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
