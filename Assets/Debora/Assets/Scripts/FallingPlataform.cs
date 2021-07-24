using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour
{
    public float fallingTime;

    private TargetJoint2D target;
    private BoxCollider2D boxColl; 


    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>(); 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            Invoke("Falling", fallingTime);
        }

        if (collision.gameObject.tag == "Spike")
        {
            Destroy(gameObject);
        }

    } 
        

    void Falling()
    {
        target.enabled = false;
       

    }
    
}
