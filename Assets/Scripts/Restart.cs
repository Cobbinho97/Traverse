using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public static int scorebeforeReset; 

    // If restart button is pressed, level is reset
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.scoreAmount = scorebeforeReset;
    }
}
