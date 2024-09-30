using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BottomOfBucket : MonoBehaviour
{
    public AudioClip win;

    //Initialises audio source
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = win;
    }
    //If collision triggered with ball, youWin function from LevelControlScript is triggered
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Ball")
        {
            LevelControlScript.instance.youWin();
            Score.scoreAmount += 100;
            GetComponent<AudioSource>().Play();
        }
    }
}
