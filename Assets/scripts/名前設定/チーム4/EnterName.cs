using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class EnterName : MonoBehaviour
{
    public Text MemberText; //ハイスコアを表示するText
    public Text MemberText2; //ハイスコアを表示するText
    public string batter0 = "ちーむ4";

    public string batter1 = "打者1";
    public string batter2 = "打者2";
    public string batter3 = "打者3";
    public string batter4 = "打者4";
    public string batter5 = "打者5";
    public string batter6 = "打者6";
    public string batter7 = "打者7";
    public string batter8 = "打者8";
    public string batter9 = "打者9";

    public string batter10 = "ちーむ5";
    public string batter11 = "打者1";
    public string batter12 = "打者2";
    public string batter13 = "打者3";
    public string batter14 = "打者4";
    public string batter15 = "打者5";
    public string batter16 = "打者6";
    public string batter17 = "打者7";
    public string batter18 = "打者8";
    public string batter19 = "打者9";

    private string key0 = "batter0"; //ハイスコアの保存先キー0
    private string key1 = "batter1"; //ハイスコアの保存先キー1
    private string key2 = "batter2"; //ハイスコアの保存先キー2
    private string key3 = "batter3"; //ハイスコアの保存先キー3
    private string key4 = "batter4"; //ハイスコアの保存先キー4
    private string key5 = "batter5"; //ハイスコアの保存先キー5
    private string key6 = "batter6"; //ハイスコアの保存先キー6
    private string key7 = "batter7"; //ハイスコアの保存先キー7
    private string key8 = "batter8"; //ハイスコアの保存先キー8
    private string key9 = "batter9"; //ハイスコアの保存先キー9

    private string key10 = "batter10"; //ハイスコアの保存先キー0
    private string key11 = "batter11"; //ハイスコアの保存先キー1
    private string key12 = "batter12"; //ハイスコアの保存先キー2
    private string key13 = "batter13"; //ハイスコアの保存先キー3
    private string key14 = "batter14"; //ハイスコアの保存先キー4
    private string key15 = "batter15"; //ハイスコアの保存先キー5
    private string key16 = "batter16"; //ハイスコアの保存先キー6
    private string key17 = "batter17"; //ハイスコアの保存先キー7
    private string key18 = "batter18"; //ハイスコアの保存先キー8
    private string key19 = "batter19"; //ハイスコアの保存先キー9


    // Start is called before the first frame update
    void Start()
    {
        batter0 = PlayerPrefs.GetString(key0, "null");
        batter1 = PlayerPrefs.GetString(key1, "null");
        batter2 = PlayerPrefs.GetString(key2, "null");
        batter3 = PlayerPrefs.GetString(key3, "null");
        batter4 = PlayerPrefs.GetString(key4, "null");
        batter5 = PlayerPrefs.GetString(key5, "null");
        batter6 = PlayerPrefs.GetString(key6, "null");
        batter7 = PlayerPrefs.GetString(key7, "null");
        batter8 = PlayerPrefs.GetString(key8, "null");
        batter9 = PlayerPrefs.GetString(key9, "null");

        batter10 = PlayerPrefs.GetString(key10, "null");
        batter11 = PlayerPrefs.GetString(key11, "null");
        batter12 = PlayerPrefs.GetString(key12, "null");
        batter13 = PlayerPrefs.GetString(key13, "null");
        batter14 = PlayerPrefs.GetString(key14, "null");
        batter15 = PlayerPrefs.GetString(key15, "null");
        batter16 = PlayerPrefs.GetString(key16, "null");
        batter17 = PlayerPrefs.GetString(key17, "null");
        batter18 = PlayerPrefs.GetString(key18, "null");
        batter19 = PlayerPrefs.GetString(key19, "null");
    }
    // Update is called once per frame
    void Update()
    {
        MemberText.text = batter0+"\n\n1: " + batter1.ToString() + "\n2: " + batter2.ToString() + "\n3: " + batter3.ToString() + "\n4: " + batter4.ToString() + "\n5: " + batter5.ToString() + "\n6: " + batter6.ToString() + "\n7: " + batter7.ToString() + "\n8: " + batter8.ToString() + "\n9: " + batter9.ToString();
        PlayerPrefs.SetString(key0, batter0);
        PlayerPrefs.SetString(key1, batter1);
        PlayerPrefs.SetString(key2, batter2);
        PlayerPrefs.SetString(key3, batter3);
        PlayerPrefs.SetString(key4, batter4);
        PlayerPrefs.SetString(key5, batter5);
        PlayerPrefs.SetString(key6, batter6);
        PlayerPrefs.SetString(key7, batter7);
        PlayerPrefs.SetString(key8, batter8);
        PlayerPrefs.SetString(key9, batter9);

        MemberText2.text = batter10+"\n\n1: " + batter11.ToString() + "\n2: " + batter12.ToString() + "\n3: " + batter13.ToString() + "\n4: " + batter14.ToString() + "\n5: " + batter15.ToString() + "\n6: " + batter16.ToString() + "\n7: " + batter17.ToString() + "\n8: " + batter18.ToString() + "\n9: " + batter19.ToString();
        PlayerPrefs.SetString(key10, batter10);
        PlayerPrefs.SetString(key11, batter11);
        PlayerPrefs.SetString(key12, batter12);
        PlayerPrefs.SetString(key13, batter13);
        PlayerPrefs.SetString(key14, batter14);
        PlayerPrefs.SetString(key15, batter15);
        PlayerPrefs.SetString(key16, batter16);
        PlayerPrefs.SetString(key17, batter17);
        PlayerPrefs.SetString(key18, batter18);
        PlayerPrefs.SetString(key19, batter19);


    }
}
