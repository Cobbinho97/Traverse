using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragDrop : MonoBehaviour
{

    float deltaX, deltaY;
    Rigidbody2D rb;
    bool moveAllowed = false;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        // Touch Manager
        // Registers touches of resources
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {

                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;

                        moveAllowed = true;


                        rb.freezeRotation = true;
                        rb.velocity = new Vector2(0, 0);
                        rb.gravityScale = 0;
                        GetComponent<BoxCollider2D>();
                    }
                    break;

                    // Registers the movement of resources through touch
                case TouchPhase.Moved:
                    if (GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(touchPos) && moveAllowed)
                        rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    break;

                    // Freezes object open touch ending
                case TouchPhase.Ended:

                    moveAllowed = false;
                    rb.freezeRotation = false;
                    GetComponent<BoxCollider2D>();
                    break;
            }
        }
    }
}