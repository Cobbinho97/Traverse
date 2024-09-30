using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalLevelCompleted : MonoBehaviour
{
    public static FinalLevelCompleted instance = null;
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
    }

    //Will load final level if final level is completed
    public void youWin()
    {
        if (levelPassed < sceneIndex)
            PlayerPrefs.SetInt("LevelPassed", sceneIndex);
        levelSign.gameObject.SetActive(false);
        youWinText.gameObject.SetActive(true);
    }

    void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
}