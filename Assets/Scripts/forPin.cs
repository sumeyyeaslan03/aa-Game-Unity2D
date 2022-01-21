using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forPin : MonoBehaviour
{
    public float speed= 20f;
    public Rigidbody2D rb;
    private bool isPinned=false;

    void Update()
    {
        if(!isPinned)
        {
            rb.MovePosition(rb.position +Vector2.up *speed* Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="circle")
        {
            transform.SetParent(col.transform);
            score.pinCount ++;
            //col.GetComponent<rotateCircle>().rotateSpeed *=-1f;
            isPinned= true;
        }

        else if(col.tag=="pin")
        {
            FindObjectOfType<GameManager>().EndGame();
            Time.timeScale=0;
        }
    }
}
