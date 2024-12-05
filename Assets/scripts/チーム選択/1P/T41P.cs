using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T41P : MonoBehaviour
{
    public GameTextes gamas;
    // Start is called before the first frame update
    public GameObject team1;
    public GameObject team2;
    public GameObject team3;
    public void OnClickStartButton()
    {
        team1.gameObject.SetActive(false);
        team2.gameObject.SetActive(false);
        team3.gameObject.SetActive(false);

        gamas.Team1 = 3;
    }




}
