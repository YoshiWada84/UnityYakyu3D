using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleBack : MonoBehaviour
{
    
    public void Start()
    {
        
    }
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Title");
    }


}