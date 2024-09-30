using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // If collision is triggered, the coin object is destroyed and score is added
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Ball")
        {
            AudioSource coincollect = GetComponent<AudioSource>();
            coincollect.Play(); 
            Destroy(gameObject, 0.5f);
            Score.scoreAmount += 50;
        }
    }
}
