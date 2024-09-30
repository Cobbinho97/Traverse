using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHome : MonoBehaviour
{
    //If home button pressed, Main Menu scene is loaded
    public void BackHome()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
