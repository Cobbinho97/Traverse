using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    //After pressing the start game button, the next active scene will be loaded
    public void StartofGame()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    // If quit game button is pressed, game is quited
    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
