using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundChange : MonoBehaviour
{
    public AudioSource sound01;
    public GameTextes gamas;
    // Start is called before the first frame update
    

    void Start()
    {
        //AudioSource�R���|�[�l���g���擾���A�ϐ��Ɋi�[
        sound01 = GetComponent<AudioSource>();
    }
    public void OnClickStartButton()
    {
        
        sound01.Stop();
        sound01.PlayOneShot(sound01.clip);
        
        
    }




}
