using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game9Inning : MonoBehaviour
{
    public AudioSource sound01;
    public GameTextes gamas;
    // Start is called before the first frame update
    public GameObject team1;
    

    void Start()
    {
        //AudioSource�R���|�[�l���g���擾���A�ϐ��Ɋi�[
        sound01 = GetComponent<AudioSource>();
    }
    public void OnClickStartButton()
    {
        team1.gameObject.SetActive(false);

        gamas.game = true;
        sound01.Stop();
        sound01.PlayOneShot(sound01.clip);
        
        
    }




}
