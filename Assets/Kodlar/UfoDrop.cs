using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoDrop : MonoBehaviour
{     //   Instantiate(pref[0], transform.position, Quaternion.identity);
    public GameObject ball1,ball2,ball3,rope1,rope2,rope3;
    public Animator ufo3, ufo4, ufo5,rope1a,rope2a,rope3a;
   // Vector2 temp =new Vector2(-6.814f,-0.947f);

   
    void OnTriggerEnter2D(Collider2D col)
    {
        //-6,814 -0.947 0
        if (col.gameObject.tag == "rope")
        {
            ufo3.SetTrigger("ufo3drop");
            rope1a.SetTrigger("ropeDest");
            Invoke("Destroy(rope1)", 1);
            Destroy(ball1);
            ball1.gameObject.SetActive(false);
            ball2.gameObject.SetActive(true);


        }
        else if (col.gameObject.tag == "rope2")
        {
        
            ufo4.SetTrigger("ufo4drop");
            rope2a.SetTrigger("Rope2DestAnim");
            Invoke("Destroy(rope2)",1);
            Destroy(ball2);
            ball3.gameObject.SetActive(true);

        }
        else if (col.gameObject.tag == "rope3")
        {

            ufo5.SetTrigger("ufo5drop");
            rope3a.SetTrigger("Rope3DestAnim");
            Invoke("Destroy(rope3)", 1);
            Destroy(ball3);
        }
        else if (col.gameObject.tag == "zzz")
        {

            Destroy(ball1);
        }

    }

    public void deneme()
    {

    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
