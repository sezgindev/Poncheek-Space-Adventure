using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class görünmezol : MonoBehaviour
{
    public Animator s1, s2, s3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            s1.SetTrigger("yogol");
            s2.SetTrigger("yogol");
            s3.SetTrigger("yogol");
        }
    }
}
