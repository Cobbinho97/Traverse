using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour
{
    public static LevelControlScript instance = null;
    GameObject levelSign, youWinText;
    int sceneIndex, levelPassed;
 
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        levelSign = GameObject.Find("LevelNumber");
        youWinText = GameObject.Find("YouWinText");
        youWinText.gameObject.SetActive(false);

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        Restart.scorebeforeReset = Score.scoreAmount;
    }

    // Process win condition, displaying text and resturning to the level selection screen
    public void youWin()
    {
        if (sceneIndex == 12)
            Invoke("loadGameCompleted", 2f);
        else
        {
            PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            levelSign.gameObject.SetActive(false);
            youWinText.gameObject.SetActive(true);
            Invoke("loadCompletedLevel", 1f);
        }
    }

    void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    //Will load level selection screen if current level is completed
    void loadCompletedLevel()
    {
            SceneManager.LoadScene("CompletedLevel");
    }

    //Will load game completed screen upon final level being completed
    void loadGameCompleted()
    {
            SceneManager.LoadScene("GameCompleted");
    }
}
