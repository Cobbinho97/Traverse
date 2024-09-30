using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    //Upon playing Ambient sound, Sound will continue to loop
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
