using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Portal;
    public AudioClip teleporting;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = teleporting;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //If collision is triggered, coroutine of teleportation is triggered
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            StartCoroutine(Teleport());
            GetComponent<AudioSource>().Play();
        }
    }
    
    //Teleports object that collides with first teleport object to second teleport object
    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0.5f);
        Ball.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    }
}
