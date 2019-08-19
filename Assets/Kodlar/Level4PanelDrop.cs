using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4PanelDrop : MonoBehaviour
{
    public Rigidbody2D[] rb = new Rigidbody2D[2];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "panel1")
        {
            Invoke("deneme1", 0.2f);
        }
        else if (col.gameObject.tag == "panel2")
        {
            Invoke("deneme2", 0.2f);
        }
     
        }

     public void deneme1()
    {
        rb[0].isKinematic = false;
        rb[0].gravityScale = 1;
    }
    public void deneme2()
    {
        rb[1].isKinematic = false;
        rb[1].gravityScale = 1;
    }
}
