using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextes : MonoBehaviour
{
    public Text InningText;     //回数
    public Text AttackText;     //先攻チームの得点
    public Text DeffenceText;   //後攻チームの得点
    public Text RunnerText;     //ランナー
    public Text StrikeText;     //ストライクカウント
    public Text OutText;        //アウトカウント

    public int Inning;      //回数
    public int Inning2;      //表裏
    public int Team1;      //チーム先攻
    public int Team2;      //チーム後攻

    public int AtkPt;       //先攻チームの得点数
    public int DefPt;       //後攻チームの得点数
    public int Runner;      //ランナー
    public int Strike;      //ストライク数
    public int Out;         //アウトの数
    public bool gameset;         //試合終了か否か

    // Start is called before the first frame update
    void Start()
    {
        Inning = 1;
        Inning2 = 0;
        Team1 = 2;
        Team2 = 2;
        AtkPt = 0;
        DefPt = 0;
        Runner = 0;
        Strike = 0;
        Out = 0;
        gameset = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Inning2 == 0)
        {
            InningText.text = string.Format("{0}回表", Inning);
        }
        if (Inning2 == 1)
        {
            InningText.text = string.Format("{0}回裏", Inning);
        }
        if (Team1 == 0)
        {
            AttackText.text = string.Format("たいがーす：{0}", AtkPt);
        }
        else if (Team1 == 1)
        {
            AttackText.text = string.Format("ぺりーず：{0}", AtkPt);
        }
        else
        {
            AttackText.text = string.Format("先攻チーム：{0}", AtkPt);
        }
        if (Team2 == 0)
        {
            DeffenceText.text = string.Format("たいがーす：{0}", DefPt);
        }
        else if (Team1 == 1)
        {
            DeffenceText.text = string.Format("ぺりーず：{0}", DefPt);
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
            StrikeText.text = string.Format("後攻チームの勝ち");
            OutText.text = string.Format("");
            gameset = true;

           
}
        else if (4 <= Inning && (AtkPt > DefPt))
        {
            InningText.text = string.Format("試合終了");
            StrikeText.text = string.Format("先攻チームの勝ち");
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
    }
    void FixedUpdate()
    {
        if (2 < Strike)
        {
            Strike = 0;
            Out++;
        }
        if (2 < Out)
        {
            Out = 0;
            Runner = 0;
            Inning2++;
        }
        if (1 < Inning2)
        {
            Inning2 = 0;
            Inning++;
        }
        
    }
}
