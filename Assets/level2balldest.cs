using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2balldest : MonoBehaviour
{
    public GameObject[] toplar;
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
        if (col.gameObject.tag == "zzzz") {
            Destroy(this.gameObject);
            if (this.gameObject.tag == "ball1")
            {
                toplar[1].gameObject.SetActive(true);

            }
            else if (this.gameObject.tag == "ball2")
            {
                toplar[2].gameObject.SetActive(true);
                Destroy(toplar[1]);
            }

        }
      
    }
}

