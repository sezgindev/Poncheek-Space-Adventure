using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3ufoDrop : MonoBehaviour
{
    public Rigidbody2D[] rb = new Rigidbody2D[4];

    public void Start()
    {

    }
  


    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ufo")
        {
            Invoke("deneme1", 0.6f);
        }
       else if (col.gameObject.tag == "ufo1")
        {
            Invoke("deneme2", 0.6f);
        }
       else if (col.gameObject.tag == "ufo2")
        {
            Invoke("deneme3", 0.6f);
        }
       else if (col.gameObject.tag == "ufo4")
        {
            Invoke("deneme4", 0.6f);
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
        rb[1].gravityScale = 1f;
    }
    public void deneme3()
    {
        rb[2].isKinematic = false;
        rb[2].gravityScale = 1;
    }
    public void deneme4()
    {
        rb[3].isKinematic = false;
        rb[3].gravityScale = 1;
    }
   

}
  

    

