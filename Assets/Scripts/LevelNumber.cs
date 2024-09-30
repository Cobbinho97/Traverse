using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumber : MonoBehaviour
{
    Text text;
    int sceneIndex;

    // Start is called before the first frame update
    // Loads Level Number depending on scene
    void Start()
    {
        text = GetComponent<Text>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;

    }

    // Outputs current level number to Scene
    void Update()
    {
        text.text = "Level" + sceneIndex;
    }
}
