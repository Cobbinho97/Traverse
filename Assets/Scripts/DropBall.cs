using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBall : MonoBehaviour
{

    float deltaX, deltaY;
    Rigidbody2D ball;
    bool moveAllowed = false;
    private bool moving = false;
    public AudioSource audioSource;
    public AudioClip death;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        GetComponent<CircleCollider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // TouchManager
        // If touch is registered
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if (GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(touchPos))
                    {

                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;

                        moveAllowed = true;

                        //if ball object is touched, it will drop by adding gravity and velocity to the ball
                        ball.freezeRotation = true;
                        ball.velocity = new Vector2(0, 0);
                        ball.gravityScale = 25;
                        moving = true;
                        GetComponent<CircleCollider2D>();
                    }
                    break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If collision is triggered, velocity is increased
        if (collision.gameObject.tag == "Boost")
        {
            ball.velocity = ball.velocity * 2.5f;
        }

        //If collision is triggered, ball object is destroyed
        if (collision.tag == "Spikes")
        {
            audioSource.PlayOneShot(death);
            Destroy(gameObject, 0.8f);
        }
    }
}