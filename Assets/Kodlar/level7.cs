using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level7 : MonoBehaviour
{
    public GameObject meteor;
    public Rigidbody2D rb;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1.35f) {

        Instantiate(meteor, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
       if(col.gameObject.tag=="Player")
        {
            rb.gravityScale = 1;
            Debug.Log("zz");
        }
      
    }
}
