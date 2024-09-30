using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bounce : MonoBehaviour
{
    private Rigidbody2D ball;

    //If collison is triggered, ball velocity is increased
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            ball.angularVelocity = ball.angularVelocity * 3;
        }
    }
}
