using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart1 : MonoBehaviour
{
    public GameTextes1 gamas;
    // Start is called before the first frame update

    public void OnClickStartButton()
    {
        gamas.CText.gameObject.SetActive(false);
        gamas.Wait = false;
        gamas.change = true;
        gamas.hour = 0;
        gamas.min = 0;
        gamas.sec = 0;
        gamas.Ball.timer = 0;
        
        gamas.CText2.gameObject.SetActive(false);
    }




}
